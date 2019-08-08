﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
#if NETFX_CORE
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#elif XAMARIN
using Windows.UI.Xaml.Controls;
using System.Globalization;
#endif

namespace UITests.Shared.Windows_System.PerformanceTestsControl
{
#if HAS_UMBRELLA_UI
	[SampleControlInfoAttribute("PerformanceTestsControl", "RxValueTypePerformance", typeof(Uno.UI.Samples.Presentation.SamplePages.PerformanceViewModel))]
#endif
	public sealed partial class RxValueTypePerformance : UserControl
	{
		public RxValueTypePerformance()
		{
			this.InitializeComponent();
		}
	}
}