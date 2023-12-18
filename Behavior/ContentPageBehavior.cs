using Syncfusion.Maui.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPopup
{
    public class ContentPageBehavior : Behavior<ContentPage>
    {
        private Button myButton;
        private SfPopup myPopup;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            this.myButton = bindable.FindByName<Button>("showPopupButton");
            this.myPopup = bindable.FindByName<SfPopup>("popUpLayout");
            myButton.Clicked += MyButton_Clicked;
            base.OnAttachedTo(bindable);

        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            this.myPopup.Show();
        }

        protected override void OnDetachingFrom(ContentPage bindablePage)
        {
            base.OnDetachingFrom(bindablePage);
            // Add cleanup logic if needed
            myButton = null;
            myPopup = null;
        }
    }
}
