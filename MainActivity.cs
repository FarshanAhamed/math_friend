using System;
//using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace math_friend
{
	[Activity (Label = "CalcMe", MainLauncher = true, Icon = "@drawable/calculatoricon")]

		
	public class MainActivity : Activity
	{
		

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.MainLayout);

//			public void numblock ()
//			{
//					Toast.MakeText(this,"Number too long",ToastLength.Long).Show();
//			}
//				

			// Get our button from the layout resource,
			// and attach an event to it
			int count=0;
			float num1=0,num,InputNum =0 ;
		    float result = 0;
			String sign=" ";

			Button one = FindViewById <Button> (Resource.Id.number_one);
			Button two = FindViewById<Button> (Resource.Id.number_two);
			Button three = FindViewById<Button> (Resource.Id.number_three);
			Button four = FindViewById<Button> (Resource.Id.number_four);
			Button five = FindViewById<Button> (Resource.Id.number_five);
			Button six = FindViewById<Button> (Resource.Id.number_six);
			Button seven = FindViewById<Button> (Resource.Id.number_seven);
			Button eight = FindViewById<Button> (Resource.Id.number_eight);
			Button nine = FindViewById<Button> (Resource.Id.number_nine);
			Button zero = FindViewById <Button> (Resource.Id.number_zero);
			Button addnum = FindViewById<Button> (Resource.Id.plus_button);
			Button subnum = FindViewById<Button> (Resource.Id.minus_button);
			Button mulnum = FindViewById<Button> (Resource.Id.into_button);
			Button divnum = FindViewById<Button> (Resource.Id.div_button);
			Button equal = FindViewById <Button> (Resource.Id.equal_button);
			Button clear = FindViewById<Button> (Resource.Id.button_clear);
		    TextView ResultSpace = FindViewById <TextView> (Resource.Id.MainScreen);
			TextView SignSpace = FindViewById<TextView> (Resource.Id.SignScreen);
			clear.Click += delegate {
				InputNum=0;
				result=0;
				count=0;
				sign=" ";
				ResultSpace.Text=result.ToString();
				SignSpace.Visibility=ViewStates.Invisible;
				
			};
			one.Click += delegate {
				if(count<7){
				num = 1;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
				};
			two.Click += delegate {
				if(count<7){
				num = 2;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			three.Click += delegate {
					if(count<7){
				num = 3;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			four.Click += delegate {
						if(count<7){
				num = 4;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			five.Click += delegate {
							if(count<7){
				num = 5;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			six.Click += delegate {
								if(count<7){
				num = 6;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			seven.Click += delegate {
									if(count<7){
				num = 7;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			eight.Click += delegate {
										if(count<7){
				num = 8;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			nine.Click += delegate {
											if(count<7){
				num = 9;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
					count++;
				}
			};
			zero.Click += delegate {
				num = 0;
				InputNum = InputNum * 10 + num;
				ResultSpace.Text = String.Format ("{0}", InputNum);
			
			};

			addnum.Click += delegate {
				
				if(sign=="plus")
				{
					result = num1 + InputNum;
					ResultSpace.Text =  result.ToString();
					num1=result;
					InputNum = 0;

				}
				else if(sign=="minus")
				{
					result =num1-InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					num1=result;
					InputNum = 0;
				}
				else if(sign=="into")
				{
					result =num1*InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					num1=result;
					InputNum = 0;
				}
				else if(sign=="div")
				{
					if (InputNum == 0) {
						ResultSpace.Text = String.Format ("Math Error");}
					else
					{
						result =(float)num1/(float)InputNum;
						ResultSpace.Text =result.ToString();
						num1=result;
						InputNum = 0;
					}
				}

				else
				{
					num1=InputNum;

				}
				
				sign="plus";
				InputNum=0;
				count=0;
				SignSpace.Text="+";
				SignSpace.Visibility=ViewStates.Visible;
			};
			subnum.Click += delegate {
				if(sign=="plus")
				{
					result = num1 + InputNum;
					ResultSpace.Text =  result.ToString();
					num1=result;
					InputNum = 0;
				}
				else if(sign=="minus")
				{
					result =num1-InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					num1=result;
					InputNum = 0;
				}
				else if(sign=="into")
				{
					result =num1*InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="div")
				{
					if (InputNum == 0) {
						ResultSpace.Text = String.Format ("Math Error");}
					else
					{
						result =(float)num1/(float)InputNum;
						ResultSpace.Text =result.ToString();
						InputNum = 0;
					}
				}

				else
				{
					num1=InputNum;	
				}

				sign="minus";
				InputNum=0;
				count=0;
				SignSpace.Text="-";
				SignSpace.Visibility=ViewStates.Visible;
			};
			mulnum.Click += delegate {
				if(sign=="plus")
				{
					result = num1 + InputNum;
					ResultSpace.Text =  result.ToString();
					InputNum = 0;
				}
				else if(sign=="minus")
				{
					result =num1-InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="into")
				{
					result =num1*InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="div")
				{
					if (InputNum == 0) {
						ResultSpace.Text = String.Format ("Math Error");}
					else if(sign=="equalto"){
						num1=result;
					}
					else
					{
						result =(float)num1/(float)InputNum;
						ResultSpace.Text =result.ToString();
						InputNum = 0;
					}
				}
				else
				{
					num1=InputNum;	
				}

				sign="into";
				InputNum=0;
				count=0;
				SignSpace.Text="*";
				SignSpace.Visibility=ViewStates.Visible;
			};

			divnum.Click += delegate {
				if(sign=="plus")
				{
					result = num1 + InputNum;
					ResultSpace.Text =  result.ToString();
					InputNum = 0;
				}
				else if(sign=="minus")
				{
					result =num1-InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="into")
				{
					result =num1*InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="div")
				{
					if (InputNum == 0) {
						ResultSpace.Text = String.Format ("Math Error");}
					else
					{
						result =(float)num1/(float)InputNum;
						ResultSpace.Text =result.ToString();
						InputNum = 0;
					}
				}


				else
				{
					num1=InputNum;	
				}

				sign="div";
				InputNum=0;
				count=0;
				SignSpace.Text="/";
				SignSpace.Visibility=ViewStates.Visible;
			};
			equal.Click += delegate {
				
				if(sign=="plus")
					{
					result = num1 + InputNum;
					ResultSpace.Text =  result.ToString();
						InputNum = 0;
						}
				else if(sign=="minus")
				{
				result =num1-InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="into")
				{
					result =num1*InputNum;
					ResultSpace.Text = String.Format ("{0}", result);
					InputNum = 0;
				}
				else if(sign=="div")
				{
					if (InputNum == 0) {
						ResultSpace.Text = String.Format ("Math Error");}
					else
					{
						result =(float)num1/(float)InputNum;
						ResultSpace.Text =result.ToString();
					InputNum = 0;
					}
				}
				sign="equalto";
				count=0;
				SignSpace.Visibility=ViewStates.Invisible;
			};
	
		
		}

		}
}

	