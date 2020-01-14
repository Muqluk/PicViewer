using System;
using System.Collections.Generic;
using System.Text;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace PicViewer.ViewModel {
  public class MainViewModel : ViewModelBase {
    public MainViewModel() {
      System.Windows.MessageBox.Show("Derp");
    }
  }
}
