using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue, imperialValue, yardvalue, pondvalue;

        // プロパティ
        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        public double YardValue {
            get { return this.yardvalue; }
            set {
                this.yardvalue = value;
                this.OnPropertyChanged();
            }
        }

        public double PondValue {
            get { return this.pondvalue; }
            set {
                this.pondvalue = value;
                this.OnPropertyChanged();
            }
        }

        // 上のComboBoxで選択されている値(単位)
        public MetricUnit CurrentMetricUnit { get; set; }

        public YardUnit CurrentYardUnit { get; set; }

        // 下のComboBoxで選択されている値(単位)
        public ImperialUnit CurrentImperialUnit { get; set; }

        public PondUnit CurrentPondUnit { get; set; }

        // ▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        public ICommand PondToYardUnit { get; private set; }

        // ▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        public ICommand YardUnidToPond { get; private set; }
        
        // コンストラクタ
        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();
            this.CurrentYardUnit = YardUnit.Units.First();
            this.CurrentPondUnit = PondUnit.Units.First();

            this.MetricToImperialUnit = new DelegateCommand(
                () => this.ImperialValue = this.CurrentImperialUnit.FromMetricUnit(
                    this.CurrentMetricUnit, this.MetricValue));

            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
                    this.CurrentImperialUnit, this.ImperialValue));

            this.YardUnidToPond = new DelegateCommand( 
                () => this.YardValue = this.CurrentYardUnit.FromPondUnit(
                    this.CurrentPondUnit, this.pondvalue));
                

            this.PondToYardUnit = new DelegateCommand(
                () => this.PondValue = this.CurrentPondUnit.FromYardUnit(
                    this.CurrentYardUnit, this.yardvalue));
             
        }
    }
}
