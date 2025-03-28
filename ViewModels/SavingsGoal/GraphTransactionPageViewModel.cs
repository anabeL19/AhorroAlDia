using SmartSave.Model.SavingsGoal;
using System.Collections.ObjectModel;

namespace SmartSave.ViewModels.SavingsGoal
{
    public partial class GraphTransactionPageViewModel
    {
        public ObservableCollection<TransferResponseV1> DataTranfer { get; set; }
        public ObservableCollection<TransferResponseV1> DataTranfer1 { get; set; }

        public GraphTransactionPageViewModel() 
        { 
            this.DataTranfer = GetCategoricalData();
            this.DataTranfer1 = GetCategoricalData1();
        }
        private static ObservableCollection<TransferResponseV1> GetCategoricalData()
        {
            var data = new ObservableCollection<TransferResponseV1>  {
            new TransferResponseV1 { Category = "1pm", Value = 0.63 },
            new TransferResponseV1 { Category = "2pm", Value = 0.85 },
            new TransferResponseV1 { Category = "3pm", Value = 1.05 },
            new TransferResponseV1 { Category = "4pm", Value = 0.96 },
            new TransferResponseV1 { Category = "5pm", Value = 0.78 },
            };


            return data;
        }

        private static ObservableCollection<TransferResponseV1> GetCategoricalData1()
        {
            var data = new ObservableCollection<TransferResponseV1>  {
            new TransferResponseV1 { Category = "1pm", Value = 0.53 },
            new TransferResponseV1 { Category = "2pm", Value = 0.55 },
            new TransferResponseV1 { Category = "3pm", Value = 0.05 },
            new TransferResponseV1 { Category = "4pm", Value = 0.26 },
            new TransferResponseV1 { Category = "5pm", Value = 0.18 },
            };


            return data;
        }
    }
}
