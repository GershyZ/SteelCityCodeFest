using System;      
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldAgentForm
{	
	public partial class IAFormPage2 : ContentPage
	{
		public IAFormPage2 ()
		{
			InitializeComponent ();
		}

        private void btn_photos_Clicked(object sender, EventArgs e)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>();
            form_data["damage_foundation"] = e_damage_foundation.Text;
            form_data["damage_floor"] = e_damage_floor.Text;
            form_data["damage_exterior"] = e_damage_exterior.Text;
            form_data["damage_roof"] = e_damage_roof.Text;
            form_data["damage_interior"] = e_damage_interior.Text;
            form_data["damage_plumbing"] = e_damage_plumbing.Text;
            form_data["damage_hvac"] = e_damage_heating.Text;
            form_data["damage_electrical"] = "0";

            form_data["flood_insurance"] = "FALSE";
            form_data["insurance_structure"]="0";
            form_data["insurance_contents"]="0";
            form_data["insurance_land"]="0";

            form_data["marketvalue_structure"] = "0";
            form_data["marketvalue_contents"] = "0";
            form_data["marketvalue_land"] = "0";

            form_data["name_insurance"] = "Codefest Insurance";
            form_data["phone_insurance"]="";
            form_data["disaster_structure"] = "0";
            form_data["disaster_contents"] = "";
            form_data["disaster_land"] = "";
            form_data["comments"] = "";

            App.addFormData(form_data);
            App.SendData();
            App.Current.MainPage = new PhotoRefPage();
        }
    }
}
