using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Models;
using BL;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ProductInShop> productsInShop;

        
        public ObservableCollection<ProductInShop> ProductInShops { get => productsInShop; set
            {
                productsInShop = value;
                OnPropertyChanged(nameof(ProductInShops));
            }
        }
        private ProductInShop selectedProductInShop;
        public ProductInShop SelectedProductInShop
        {
            get { return selectedProductInShop; }
            set { selectedProductInShop = value; OnPropertyChanged(nameof(SelectedProductInShop)); }
        }
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; OnPropertyChanged(nameof(ProductName)); }
        }

        private DateTime endDate = DateTime.Now.AddDays(7);
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; OnPropertyChanged(nameof(EndDate)); }
        }

        private string userLogin;
        public string UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; OnPropertyChanged(nameof(UserLogin)); }
        }
        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; OnPropertyChanged(nameof(UserPassword)); }
        }

        private User user;

        private RelayCommand findProductInShopsByProductName;
        public RelayCommand FindProductInShopsByProductName
        {
            get
            {
                return findProductInShopsByProductName ?? (findProductInShopsByProductName = new RelayCommand(obj =>
                {
                    //ProductInShops.Clear();
                    //OnPropertyChanged();
                    ProductInShops = new ObservableCollection<ProductInShop>();
                    IList<ProductInShop> result = productInShopService.GetProductInShopsByProductName(ProductName);
                    //foreach (var pis in productInShopService.GetProductInShopsByProductName(ProductName))
                    foreach(ProductInShop pis in result)
                    {
                        
                        ProductInShops.Add(pis);
                        MessageBox.Show(pis.Quantity.ToString());
                    }
                }, obj=>(ProductName!=null && !ProductName.Equals(""))));
            }
        }
        private RelayCommand makeBooking;
        public RelayCommand MakeBooking
        {
            get
            {
                return makeBooking ?? (makeBooking = new RelayCommand(obj =>
                {
                    MessageBox.Show(SelectedProductInShop.Product.Id.ToString());
                    bookingService.MakeBooking(user, SelectedProductInShop, DateTime.Now, EndDate);
                    FindProductInShopsByProductName.Execute(null);
                }, obj => (user != null && EndDate!=null && SelectedProductInShop != null)));
            }
        }
        private RelayCommand showLoginWindow;
        public RelayCommand ShowLoginWindow
        {
            get
            {
                return showLoginWindow ?? (showLoginWindow = new RelayCommand(obj =>
                {
                    navigationService.ShowLoginWindow(this);
                }));
            }
        }

        private RelayCommand login;
        public RelayCommand Login
        {
            get
            {
                return login ?? (login = new RelayCommand(obj =>
                {
                    user = userService.GetUserByLoginAndPassword(UserLogin, UserPassword);
                    OnPropertyChanged();
                }, obj=> UserLogin!=null && !UserLogin.Equals("") && UserPassword != null && !UserPassword.Equals("")));
            }
        }


        private IUserService userService;
        private IProductInShopService productInShopService;
        private IBookingService bookingService;
        private NavigationService navigationService;
        public MainViewModel(IUserService userService, IProductInShopService productInShopService, IBookingService bookingService, NavigationService navigationService)
        {
            this.userService = userService;
            this.productInShopService = productInShopService;
            this.bookingService = bookingService;
            this.navigationService = navigationService;
            ProductInShops = new ObservableCollection<ProductInShop>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
