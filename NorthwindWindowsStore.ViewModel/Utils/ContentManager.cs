namespace NorthwindWindowsStore.ViewModel.Utils
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Threading.Tasks;

    public static class ContentManager
    {
        public static async Task<List<O>> GetContent<I, O>(String webPath)
            where I : class, new()
            where O : class, new()
        {
            List<O> output = new List<O>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/NorthwindWindowsStoreService/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetStreamAsync(webPath).ConfigureAwait(continueOnCapturedContext: false);

                HttpResponseMessage response = await client.GetAsync(webPath);
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    List<I> serviceVM = JsonConvert.DeserializeObject<List<I>>(json);
                    ConstructorInfo ci = null;
                    var info = typeof(O).GetTypeInfo();
                    foreach (var ctor in info.DeclaredConstructors)
                    {
                        if (ctor.GetParameters().Count() > 0)
                        {
                            if (ctor.GetParameters()[0].ParameterType.Name.Equals(typeof(I).Name))
                            {
                                ci = ctor;
                            }
                        }
                    }
                    foreach (var item in serviceVM)
                    {
                        if (item != null)
                        {
                            O obj = ci.Invoke(new object[] { item }) as O;
                            if (obj != null)
                            {
                                output.Add(obj);
                            }
                        }
                    }
                }
            }
            return output;
        }
    }
}
