namespace EnergyCollab.Services.API.HelperMethod
{
    public static class Helper
    {
        public static string GetCategoryName(int categoryId)
        {
            string result = categoryId switch
            {
                1 => "Contract",
                2 => "FullTime",
                3 => "PartTime"
            };

            return result;
        }
    }
}
