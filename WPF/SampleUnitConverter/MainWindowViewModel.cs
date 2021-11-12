using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        //自動実装プロパティ
        private double metricValue;
        private double imperialValue;

        //▲ボタンで呼ばれるコマンド[ヤード単位からメートル単位]
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼ボタンで呼ばれるコマンド[メートル単位からヤード単位]
        public ICommand MetricToImperialUnit { get; private set; }


        ////上のコンボボックスで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }

        ////下のコンボボックスで選択されている値
        public ImperialUnit CurrentInperialUnit { get; set; }

        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();//Viewに通知
            }
        }
        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();//Viewに通知


            }
        }
        public MainWindowViewModel()            
            {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentInperialUnit = ImperialUnit.Units.First();
            this.MetricToImperialUnit 
                = new DelegateCommand(
                () => this.ImperialValue =
                this.CurrentInperialUnit.FromMetricUnit(this.CurrentMetricUnit, this.MetricValue));

            this.ImperialUnitToMetric = 
                new DelegateCommand(
                    () => this.MetricValue = this.CurrentMetricUnit
              .FromImperialUnit(this.CurrentInperialUnit, this.ImperialValue));




        }
    }


}
