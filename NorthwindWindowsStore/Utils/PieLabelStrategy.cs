namespace NorthwindWindowsStore.Utils
{
    using System;
    using Telerik.Charting;
    using Telerik.UI.Xaml.Controls.Chart;

    public class PieLabelStrategy : ChartSeriesLabelStrategy
    {
        private string format = "{0} ({1} %)";

        public PropertyNameDataPointBinding Binding { get; set; }

        public override LabelStrategyOptions Options
        {
            get { return LabelStrategyOptions.Content; }
        }

        public PieLabelStrategy()
        {
        }

        public override object GetLabelContent(DataPoint point, int labelIndex)
        {
            if (point == null || labelIndex < 0)
            {
                return base.GetLabelContent(point, labelIndex);
            }

            return string.Format(this.format, ((NorthwindWindowsStore.Utils.ChartData)(point.DataItem)).Label, Math.Round(((PieDataPoint)point).Percent));
        }
    }
}
