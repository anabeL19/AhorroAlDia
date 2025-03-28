using AndroidX.Lifecycle;
using Telerik.Maui.Controls.Compatibility.Chart;

namespace SmartSave.Views.SavingsGoal;

public partial class GraphTransactionPage : ContentPage
{
	public GraphTransactionPage()
	{
		InitializeComponent();

        var chart = new RadCartesianChart
        {
            HorizontalAxis = new CategoricalAxis(),
            VerticalAxis = new NumericalAxis(),
        };

        var series = new BarSeries();

        series.SetBinding(ChartSeries.ItemsSourceProperty, new Binding("Data"));

        series.ValueBinding = new PropertyNameDataPointBinding { PropertyName = "Value" };
        series.CategoryBinding = new PropertyNameDataPointBinding { PropertyName = "Category" };

        chart.Series.Add(series);
    }
}