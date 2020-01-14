using GalaSoft;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
//using CommonServiceLocator;

namespace PicViewer.ViewModel {
  public class ViewModelLocator {
    public ViewModelLocator() {
      SimpleIoc.Default.Register<MainViewModel>();
    }
    public MainViewModel Main {
      get {
        return SimpleIoc.Default.GetInstance<MainViewModel>();
      }
    }
  }
}