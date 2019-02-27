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

        #endregion



        #region Constructor

        public TheTester(int numberOfObjects)
        {
            _numberOfObjects = numberOfObjects;

            _testModelArray = new TestModel[_numberOfObjects];
            _testModelList = new List<TestModel>();
            _testModelDictionary = new Dictionary<int, TestModel>();
            _testModelObservableCollection = new ObservableCollection<TestModel>();
            AllTestResults = new Dictionary<string, TestResult>();
        }

        #endregion



        #region Properties

        public Dictionary<string, TestResult> AllTestResults { get; }

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
            Console.Write("Start TestSingleThreaded ArrayComparer");
            ArrayComparer arrayComparer = new ArrayComparer(_testModelArray);
            AllTestResults.Add("SingleThreaded_Array", arrayComparer.TestResult);

            Console.Write("Start TestSingleThreaded ListComparer");
            ListComparer listComparer = new ListComparer(_testModelList);
            AllTestResults.Add("SingleThreaded_List", listComparer.TestResult);

            Console.Write("Start TestSingleThreaded DictionaryComparer");
            DictionaryComparer dictionaryComparer = new DictionaryComparer(_testModelDictionary);
            AllTestResults.Add("SingleThreaded_Dictionary", dictionaryComparer.TestResult);

            Console.Write("Start TestSingleThreaded ObservableCollectionComparer");
            ObservableCollectionComparer observableCollectionComparer = new ObservableCollectionComparer(_testModelObservableCollection);
            AllTestResults.Add("SingleThreaded_ObservableCollection", observableCollectionComparer.TestResult);
        }

        public void TestSingleExtraThreaded()
        {
            Console.Write("Start TestSingleExtraThreaded ArrayComparer");
            Task<TestResult> taskArray = Task<TestResult>.Factory.StartNew(() =>
            {
                ArrayComparer arrayComparer = new ArrayComparer(_testModelArray);
                return arrayComparer.TestResult;
            });
            taskArray.Wait();
            AllTestResults.Add("TestSingleExtraThreaded_Array", taskArray.Result);

            Console.Write("Start TestSingleExtraThreaded ListComparer");
            Task<TestResult> taskList = Task<TestResult>.Factory.StartNew(() =>
            {
                ListComparer listComparer = new ListComparer(_testModelList);
                return listComparer.TestResult;
            });
            taskList.Wait();
            AllTestResults.Add("TestSingleExtraThreaded_List", taskList.Result);

            Console.Write("Start TestSingleExtraThreaded DictionaryComparer");
            Task<TestResult> taskDictionary = Task<TestResult>.Factory.StartNew(() =>
            {
                DictionaryComparer dictionaryComparer = new DictionaryComparer(_testModelDictionary);
                return dictionaryComparer.TestResult;
            });
            taskDictionary.Wait();
            AllTestResults.Add("TestSingleExtraThreaded_Dictionary", taskDictionary.Result);

            Console.Write("Start TestSingleExtraThreaded ObservableCollectionComparer");
            Task<TestResult> taskObservableCollection = Task<TestResult>.Factory.StartNew(() =>
            {
                ObservableCollectionComparer observableCollectionComparer = new ObservableCollectionComparer(_testModelObservableCollection);
                return observableCollectionComparer.TestResult;
            });
            taskObservableCollection.Wait();
            AllTestResults.Add("TestSingleExtraThreaded_ObservableCollection", taskObservableCollection.Result);
        }

        public void TestMultiThreaded()
        {
            Console.WriteLine("Start TestMultiThreaded ArrayComparer");
            Task<TestResult> taskArray = Task<TestResult>.Factory.StartNew(() =>
            {
                ArrayComparer arrayComparer = new ArrayComparer(_testModelArray);
                return arrayComparer.TestResult;
            });

            Console.WriteLine("Start TestMultiThreaded ListComparer");
            Task<TestResult> taskList = Task<TestResult>.Factory.StartNew(() =>
            {
                ListComparer listComparer = new ListComparer(_testModelList);
                return listComparer.TestResult;
            });

            Console.WriteLine("Start TestMultiThreaded DictionaryComparer");
            Task<TestResult> taskDictionary = Task<TestResult>.Factory.StartNew(() =>
            {
                DictionaryComparer dictionaryComparer = new DictionaryComparer(_testModelDictionary);
                return dictionaryComparer.TestResult;
            });

            Console.WriteLine("Start TestMultiThreaded ObservableCollectionComparer");
            Task<TestResult> taskObservableCollection = Task<TestResult>.Factory.StartNew(() =>
            {
                ObservableCollectionComparer observableCollectionComparer = new ObservableCollectionComparer(_testModelObservableCollection);
                return observableCollectionComparer.TestResult;
            });

            Task.WaitAll(taskArray, taskList, taskDictionary, taskObservableCollection);
            AllTestResults.Add("TestMultiThreaded_Array", taskArray.Result);
            AllTestResults.Add("TestMultiThreaded_List", taskList.Result);
            AllTestResults.Add("TestMultiThreaded_Dictionary", taskDictionary.Result);
            AllTestResults.Add("TestMultiThreaded_ObservableCollection", taskObservableCollection.Result);

            Console.WriteLine("End Test Run");
        }

        #endregion



        #region Private Methods

        private void AddObjectToLists(TestModel testModel, int objectNumber)
        {
            _testModelArray[objectNumber] = testModel;
            _testModelList.Add(testModel);
            _testModelDictionary.Add(objectNumber, testModel);
            _testModelObservableCollection.Add(testModel);
        }        

        #endregion
    }
}
