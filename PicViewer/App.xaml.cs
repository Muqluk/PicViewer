using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using log4net;
using log4net.Config;

namespace PicViewer {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    ILog log = LogManager.GetLogger(typeof(App));

    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);

      XmlDocument log4netConfig = new XmlDocument();
      log4netConfig.Load(File.OpenRead("log4net.config"));
      var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(),
                 typeof(log4net.Repository.Hierarchy.Hierarchy));
      log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
      log.Debug("Initialising ...");
    }
  }
}
