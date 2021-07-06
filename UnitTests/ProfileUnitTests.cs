using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace DropLogger
{
    [TestClass]
    public class ProfileUnitTests
    {
        /// <summary>
        /// Test data
        /// </summary>
        ObservableCollection<ProfileModel> ProfileTestList = new ObservableCollection<ProfileModel>()
        {
            new ProfileModel
                {
                    id = 0,
                    DropList = new ObservableCollection<ItemModel>
                    {
                        new ItemModel
                        {
                            id = 0,
                            itemName = "Item1"
                        },
                        new ItemModel
                        {
                            id = 1,
                            itemName = "Item2"
                        }
                    },
                    logname = "First list",
                    killCount = 10,
                    tripValue = 15.0m,
                    type = "Araxii"
                },
            new ProfileModel
            {
                id = 1,
                logname = "Second list",
                killCount = 11,
                tripValue = 16.0m,
                type = "Araxii"
            },
            new ProfileModel
            {
                id = 2,
                logname = "Third log",
                killCount = 12,
                tripValue = 17.0m,
                type = "Araxii"
            }
        };

        [TestMethod]
        public void ShouldDecreaseIndex()
        {
            ProfileViewModel pviewm = new ProfileViewModel();

            //Remove the item from the list
            ProfileTestList.RemoveAt(1);

            //Restructure the list
            pviewm.RestructList(1, ProfileTestList);

            Assert.AreEqual(2, ProfileTestList.Count);
            Assert.AreEqual(1, ProfileTestList[1].id);
        }
        [TestMethod]
        public void ShouldDecreareDropListIndex()
        {
            ProfileViewModel pviewm = new ProfileViewModel();

            //Remove the item from the list that is in the profile list
            ProfileTestList[0].DropList.RemoveAt(1);

            //Restructure the list
            pviewm.RestructInnerList(1, ProfileTestList[0].DropList);

            Assert.AreEqual(1, ProfileTestList[0].DropList.Count);
            Assert.AreEqual(0, ProfileTestList[0].DropList[0].id);
        }
    }
}
