using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dotNet5780_03_7337_5029
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Host currentHost;
        List<Host> hostList;
        public MainWindow()
        {
            InitializeComponent();

            hostList = new List<Host>()
            {
                new Host()
                {
                    HostName="yacov",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="צימר",
                            Rooms=4,
                            IsSwimmingPool=false,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                "https://upload.wikimedia.org/wikipedia/he/2/2c/%D7%A6%D7%99%D7%9E%D7%A8_%D7%91%D7%A6%D7%A4%D7%95%D7%9F.JPG",
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/29341822012104215527.jpg?time=0"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName="חדר",
                            Rooms=2,
                            IsSwimmingPool=false,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                "https://upload.wikimedia.org/wikipedia/he/2/2c/%D7%A6%D7%99%D7%9E%D7%A8_%D7%91%D7%A6%D7%A4%D7%95%D7%9F.JPG",
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/29341822012104215527.jpg?time=0"
                            }
                        }
                    }

                },
                new Host()
                {
                    HostName="darmoni",
                    Units=new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="חדר מלון",
                            Rooms=5,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                 "https://upload.wikimedia.org/wikipedia/he/2/2c/%D7%A6%D7%99%D7%9E%D7%A8_%D7%91%D7%A6%D7%A4%D7%95%D7%9F.JPG",
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/29341822012104215527.jpg?time=0"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName="צימר בעמק",
                            Rooms=4,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                 "https://upload.wikimedia.org/wikipedia/he/2/2c/%D7%A6%D7%99%D7%9E%D7%A8_%D7%91%D7%A6%D7%A4%D7%95%D7%9F.JPG",
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/29341822012104215527.jpg?time=0"
                            }
                        }
                    }
                },
                new Host()
                {
                    HostName="avi",
                    Units=new List<HostingUnit>()
                    {
                         new HostingUnit()
                        {
                            UnitName="צימר בית וגן",
                            Rooms=2,
                            IsSwimmingPool=false,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                 "https://upload.wikimedia.org/wikipedia/he/2/2c/%D7%A6%D7%99%D7%9E%D7%A8_%D7%91%D7%A6%D7%A4%D7%95%D7%9F.JPG",
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/29341822012104215527.jpg?time=0"
                            }
                        },
                          new HostingUnit()
                        {
                            UnitName="צימר עץ השקד",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                 "https://upload.wikimedia.org/wikipedia/he/2/2c/%D7%A6%D7%99%D7%9E%D7%A8_%D7%91%D7%A6%D7%A4%D7%95%D7%9F.JPG",
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/29341822012104215527.jpg?time=0"
                            }
                        }
                    }
                }
            };
            cbHostList.ItemsSource = hostList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;

        }

        private void cbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }

        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }
    }
}
