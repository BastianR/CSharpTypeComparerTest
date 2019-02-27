using StringCompare.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StringCompare.Models
{
    public class TheTester
    {
        #region Fields

        private int _numberOfObjects;
        private TestModel[] _testModelArray;
        private List<TestModel> _testModelList;
        private Dictionary<int, TestModel> _testModelDictionary;
        private ObservableCollection<TestModel> _testModelObservableCollection;
        private Dictionary<string, TestResult> _allTestResults;

        #endregion



        #region Constructor

        public TheTester(int numberOfObjects)
        {
            _numberOfObjects = numberOfObjects;

            _testModelArray = new TestModel[_numberOfObjects];
            _testModelList = new List<TestModel>();
            _testModelDictionary = new Dictionary<int, TestModel>();
            _testModelObservableCollection = new ObservableCollection<TestModel>();
            _allTestResults = new Dictionary<string, TestResult>();
        }

        #endregion



        #region Public Methods

        public void FillLists()
        {
            for (int i = 0; i < _numberOfObjects; i++)
            {
                AddObjectToLists(ModelGenerator.GenerateTestModel(i), i);
            }
        }

        public void TestSingleThreaded()
        {
            Console.WriteLine("Start TestSingleThreaded ArrayComparer");
            ArrayComparer arrayComparer = new ArrayComparer(_testModelArray);
            _allTestResults.Add("SingleThreaded_Array", arrayComparer.TestResult);

            Console.WriteLine("Start TestSingleThreaded ListComparer");
            ListComparer listComparer = new ListComparer(_testModelList);
            _allTestResults.Add("SingleThreaded_List", listComparer.TestResult);

            Console.WriteLine("Start TestSingleThreaded DictionaryComparer");
            DictionaryComparer dictionaryComparer = new DictionaryComparer(_testModelDictionary);
            _allTestResults.Add("SingleThreaded_Dictionary", dictionaryComparer.TestResult);

            Console.WriteLine("Start TestSingleThreaded ObservableCollectionComparer");
            ObservableCollectionComparer observableCollectionComparer = new ObservableCollectionComparer(_testModelObservableCollection);
            _allTestResults.Add("SingleThreaded_ObservableCollection", observableCollectionComparer.TestResult);
        }

        public void TestSingleExtraThreaded()
        {
            Console.WriteLine("Start TestSingleExtraThreaded ArrayComparer");
            Task<TestResult> taskArray = Task<TestResult>.Factory.StartNew(() =>
            {
                ArrayComparer arrayComparer = new ArrayComparer(_testModelArray);
                return arrayComparer.TestResult;
            });
            taskArray.Wait();
            _allTestResults.Add("TestSingleExtraThreaded_Array", taskArray.Result);

            Console.WriteLine("Start TestSingleExtraThreaded ListComparer");
            Task<TestResult> taskList = Task<TestResult>.Factory.StartNew(() =>
            {
                ListComparer listComparer = new ListComparer(_testModelList);
                return listComparer.TestResult;
            });
            taskList.Wait();
            _allTestResults.Add("TestSingleExtraThreaded_List", taskList.Result);

            Console.WriteLine("Start TestSingleExtraThreaded DictionaryComparer");
            Task<TestResult> taskDictionary = Task<TestResult>.Factory.StartNew(() =>
            {
                DictionaryComparer dictionaryComparer = new DictionaryComparer(_testModelDictionary);
                return dictionaryComparer.TestResult;
            });
            taskDictionary.Wait();
            _allTestResults.Add("TestSingleExtraThreaded_Dictionary", taskDictionary.Result);

            Console.WriteLine("Start TestSingleExtraThreaded ObservableCollectionComparer");
            Task<TestResult> taskObservableCollection = Task<TestResult>.Factory.StartNew(() =>
            {
                ObservableCollectionComparer observableCollectionComparer = new ObservableCollectionComparer(_testModelObservableCollection);
                return observableCollectionComparer.TestResult;
            });
            taskObservableCollection.Wait();
            _allTestResults.Add("TestSingleExtraThreaded_ObservableCollection", taskObservableCollection.Result);
        }

        public void TestMultiThreaded()
        {
            Console.WriteLine("Start TestSingleExtraThreaded ArrayComparer");
            Task<TestResult> taskArray = Task<TestResult>.Factory.StartNew(() =>
            {
                ArrayComparer arrayComparer = new ArrayComparer(_testModelArray);
                return arrayComparer.TestResult;
            });

            Console.WriteLine("Start TestSingleExtraThreaded ListComparer");
            Task<TestResult> taskList = Task<TestResult>.Factory.StartNew(() =>
            {
                ListComparer listComparer = new ListComparer(_testModelList);
                return listComparer.TestResult;
            });

            Console.WriteLine("Start TestSingleExtraThreaded DictionaryComparer");
            Task<TestResult> taskDictionary = Task<TestResult>.Factory.StartNew(() =>
            {
                DictionaryComparer dictionaryComparer = new DictionaryComparer(_testModelDictionary);
                return dictionaryComparer.TestResult;
            });

            Console.WriteLine("Start TestSingleExtraThreaded ObservableCollectionComparer");
            Task<TestResult> taskObservableCollection = Task<TestResult>.Factory.StartNew(() =>
            {
                ObservableCollectionComparer observableCollectionComparer = new ObservableCollectionComparer(_testModelObservableCollection);
                return observableCollectionComparer.TestResult;
            });

            Task.WaitAll(taskArray, taskList, taskDictionary, taskObservableCollection);
            _allTestResults.Add("TestMultiThreaded_Array", taskArray.Result);
            _allTestResults.Add("TestMultiThreaded_List", taskList.Result);
            _allTestResults.Add("TestMultiThreaded_Dictionary", taskDictionary.Result);
            _allTestResults.Add("TestMultiThreaded_ObservableCollection", taskObservableCollection.Result);

            Console.WriteLine("End");
        }

        #endregion



        #region Private Methods

        private void AddObjectToLists(TestModel testModel, int objectNumber)
        {
            _testModelArray[objectNumber] = testModel;
            _testModelList.Add(testModel);
            _testModelDictionary.Add(objectNumber, testModel);
        }

        

        #endregion
    }
}
