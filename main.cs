using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;

private TextView showCurrentTime;


protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            TimePicker Tpicker = FindViewById<TimePicker>(Resource.Id.timePicker1);
            showCurrentTime = FindViewById<TextView>(Resource.Id.txt_showTime);
            setCurrentTime();
            Button button = FindViewById<Button>(Resource.Id.btnSetTime);

            button.Click += delegate {
                showCurrentTime.Text = String.Format("{0}:{1}",
                   Tpicker.CurrentHour, Tpicker.CurrentMinute); // these 2 method calles were depricated
            };
        }
        private void setCurrentTime()
        {
            string time = string.Format("{0}",
               System.DateTime.Now.ToString("HH:mm").PadLeft(2, '0'));
            showCurrentTime.Text = time;
        }
