using MvvmCross.iOS.Views;
using ProHealth.Core.ViewModels;
using System;

using UIKit;

namespace ProHealth.iOS.Views
{
    public partial class MainView : MvxViewController
    {
        public new MainViewModel ViewModel
        {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public MainView() : base("MainView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}