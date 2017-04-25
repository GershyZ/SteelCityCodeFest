using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeoWatcher;
using Xamarin.Forms;

namespace FieldAgentForm
{
    
    public partial class IAFormPage : ContentPage
	{     
        public IAFormPage ()
		{
			InitializeComponent ();
            this.Title = "Location General Information";
            btn_next.Clicked +=Btn_next_Clicked;
            //GPS will autofill
            Receptor r = new Receptor("Location", "info page");
            r.DetectLocation();
            e_lat.Text = r.Latitude.ToString();
            e_lat.IsEnabled = false;
            e_long.Text = r.Longitude.ToString();
            e_long.IsEnabled = false;


            p_damage_category.SelectedIndex = 0;
            p_disaster_type.SelectedIndex = 0;
        }

        private void Btn_next_Clicked(object sender, EventArgs e)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>();
            form_data["name_of_assessor"] = "Field Agent";
            form_data["county"] = e_county.Text;
            form_data["municipality"] = e_municipality.Text;
            form_data["code"] = e_munic_code.Text;
            form_data["name_property_owner"] = e_full_name.Text;
            form_data["street_address"] = e_street_addr.Text;
            form_data["city"] = e_city.Text;
            form_data["zip_code"] = e_zipcode.Text;
            form_data["date"] = "04/06/2017";
            form_data["lat"] = e_lat.Text;
            form_data["lng"] = e_long.Text;
            form_data["location_notes"] = e_notes.Text;
            form_data["owner_type"] = (sw_owner.IsToggled ?"home_owner":"renter");
            form_data["phone_number"] = "(412)555-5555";
            form_data["property_type"] = (sw_location_type.IsToggled ? "business" : "residential");
            form_data["home_type"] = "home";
            form_data["type_of_disaster"] = p_disaster_type.Items[p_disaster_type.SelectedIndex];
            form_data["damage_category"] = p_damage_category.Items[p_damage_category.SelectedIndex];
            App.addFormData(form_data);
            App.Current.MainPage = new NavigationPage(new IAFormPage2());
        }

        private void clearCurrentData(object sender, FocusEventArgs e)
        {
            ((Editor)sender).Text = "";
        }
    }
}
