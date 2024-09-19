namespace TestClassLib
{
    public class TestClass
	{
		public TestClass()
		{
            
        }

        public void TestMethod()
        {
            List<DetailItem> detailItems = new List<DetailItem>()
            {

            };

            detailItems.GroupBy(query => query.FamilyID);
        }

        public class DetailItem
        {
            public long? FamilyID { get; set; }
        }
    }
}

