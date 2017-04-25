using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldAgentForm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotoRefPage : ContentPage
	{
		public PhotoRefPage ()
		{
			InitializeComponent ();
            this.BindingContext = new Rox.CameraModel();
		}
	}
}
