namespace TestClassLib;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
        List<DetailItem> detailItems = new List<DetailItem>()
        {

        };

        detailItems.GroupBy(query => query.FamilyID); // Removing this line makes breakpoints in TestClassLib work again

        return true;
	}

    public class DetailItem
    {
        public long? FamilyID { get; set; }
    }
}

