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
                            UnitName="צימר",
                            Rooms=7,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                               "https://www.weekendtop.co.il/images/customerimages/25983/gallery/image_25983_b11ee2c6075f4ba99a334b36ed90f5c6.jpg?w=1028&h=510&mode=crop",
                               "https://static.wixstatic.com/media/a166f9_04c4dbdc3359490e82784844670d1098~mv2_d_4072_2736_s_4_2.jpg/v1/fill/w_468,h_428,al_c,q_80,usm_0.66_1.00_0.01/%D7%A6%D7%99%D7%9E%D7%A8%20%D7%99%D7%95%D7%A8%D7%98%20%D7%91%D7%A9%D7%95%D7%9E%D7%A8%D7%95%D7%9F%20%D7%97%D7%96%D7%99%D7%AA.webp",
                               "http://tour-yehuda.org.il/uploads/places/706/1453385454.18463.jpg"
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
                                "http://albums.tapuz.co.il/Albums/2934182/0-1/gnhifmg/29341822012104215524.jpg",
                                "http://tour-yehuda.org.il/uploads/places/687/1450083580.45503.jpg",
                                "http://nadlanbagolan.co.il/wp-content/uploads/2013/03/%D7%A6%D7%99%D7%9E%D7%A8%D7%A2%D7%A54-590x360.jpg"
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
                                "http://albums.timg.co.il/userfolders/197/2934182/29341822012104215529.jpg?time=0",
                                "https://www.zimmer.co.il/nf1/11234.jpg"
                            }
                        },
                        new HostingUnit()
                        {
                            UnitName="חדר מלון",
                            Rooms=4,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                "https://www.k-etzion.co.il/Pictures/4_20190122155127.234.JPG",
                                "https://static.wixstatic.com/media/a2125e_fe3e6823af5d441091de9e1804af3451~mv2_d_5578_3719_s_4_2.jpg/v1/fill/w_1600,h_1066,al_c,q_90/file.jpg",
                                "https://static.wixstatic.com/media/417742_c3a47100d58b4c20aa7a2e7f7156c38f.jpg/v1/fill/w_556,h_512,al_c,q_80,usm_0.66_1.00_0.01/417742_c3a47100d58b4c20aa7a2e7f7156c38f.webp"
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
                                "http://albums.timg.co.il/userfolders/197/2934182/medium/2934182201210422318.jpg?time=0",
                                "http://www.leilotlevanim.co.il/images/Swita/HP_594_386_92.jpg",
                                "https://www.weekendtop.co.il/images/customerimages/17830/gallery/image_17830_7.jpg?w=1028&h=510&mode=crop"
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
                                "http://nadlanbagolan.co.il/wp-content/uploads/2013/03/%D7%A6%D7%99%D7%9E%D7%A8-%D7%A2%D7%A5-590x360.jpg",
                                "http://tour-yehuda.org.il/uploads/places/686/1449486629.13919.jpg",
                                "https://www.weekendtop.co.il/images/customerimages/21231/gallery/image_21231_44.jpg?w=1028&h=510&mode=crop"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName="צימר בית וגן",
                            Rooms=4,
                            IsSwimmingPool=false,
                            AllOrders=new List<DateTime>(),
                            Uris=new List<string>()
                            {
                                "https://static.wixstatic.com/media/08f675_91cda018fd8c4922bcbc74a403f6d009.jpg/v1/fill/w_567,h_851,al_c,q_90,usm_0.66_1.00_0.01/08f675_91cda018fd8c4922bcbc74a403f6d009.webp",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwtjQkbtpRr0cTeZg3rA9ag1bNzgERyVMoRk0v_XAQAjvwTMHVeQ&s"
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
                                "http://albums.timg.co.il/userfolders/1/0/3370782201261181754.jpg?time=0",
                                "https://media-cdn.tripadvisor.com/media/photo-s/13/0f/2e/1d/img-20180524-191636-largejpg.jpg"
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

        private void tbHostName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
