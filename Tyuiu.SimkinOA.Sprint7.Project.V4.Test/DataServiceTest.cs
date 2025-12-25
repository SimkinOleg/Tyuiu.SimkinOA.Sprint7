namespace Tyuiu.SimkinOA.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"F:\Users\ТИУ\source\repos\Tyuiu.SimkinOA.Sprint7\Tyuiu.SimkinOA.Sprint7.Project.V4\bin\Debug\OutPutFileProject.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}