using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.Data {
  public partial class FavoritesManager {
//    static FavoritesManager defaultInstance = new FavoritesManager();
//    //MobileServiceClient client;

//#if OFFLINE_SYNC_ENABLED
//        //IMobileServiceSyncTable<Favorite> favoritesTable;


//#else
//    //IMobileServiceTable<Favorite> favoritesTable;
//#endif

////    private FavoritesManager() {
////      this.client = new MobileServiceClient(Common.CoreConstants.ApplicationURL);

////#if OFFLINE_SYNC_ENABLED
////            var store = new MobileServiceSQLiteStore("localfavorites.db");
////            store.DefineTable<Favorite>();
            
////            this.client.SyncContext.InitializeAsync(store);

////            this.favoritesTable = client.GetSyncTable<Favorite>();
////#else
////      this.favoritesTable = client.GetTable<Favorite>();
////#endif
////    }

//    public static FavoritesManager DefaultManager {
//      get {
//        return defaultInstance;
//      }
//      private set {
//        defaultInstance = value;
//      }
//    }

//    //public MobileServiceClient CurrentClient {
//    //  get { return client; }
//    //}

//    //public bool IsOfflineEnabled {
//    //  get { return favoritesTable is Microsoft.WindowsAzure.MobileServices.Sync.IMobileServiceSyncTable<Favorite>; }
//    //}

//    //public async Task<ObservableCollection<Favorite>> GetFavoritesAsync(bool syncItems = false) {
//    //  try {
////#if OFFLINE_SYNC_ENABLED
////                if (syncItems)
////                {
////                    await this.SyncAsync();
////                }
////#endif
////        IEnumerable<Favorite> items = await favoritesTable
////            .ToEnumerableAsync();

////        return new ObservableCollection<Favorite>(items);
////      }
////      catch (MobileServiceInvalidOperationException msioe) {
////        Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
////      }
////      catch (Exception e) {
////        Debug.WriteLine(@"Sync error: {0}", e.Message);
////      }
////      return null;
////    }

//    public async Task SaveFavoriteAsync(Favorite item) {
//      try {
//        if (item.Id == -1) {
//          await favoritesTable.InsertAsync(item);
//        }
//        else {
//          await favoritesTable.UpdateAsync(item);
//        }
//      }
//      catch (Exception ex) {

//      }


//    }

//#if OFFLINE_SYNC_ENABLED
//        public async Task SyncAsync()
//        {
//            ReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;

//            try
//            {
//                await this.client.SyncContext.PushAsync();

//                await this.favoritesTable.PullAsync("allFavorites", this.favoritesTable.CreateQuery());
//            }
//            catch (MobileServicePushFailedException exc)
//            {
//                if (exc.PushResult != null)
//                {
//                    syncErrors = exc.PushResult.Errors;
//                }
//            }

//            if (syncErrors != null)
//            {
//                foreach (var error in syncErrors)
//                {
//                    if (error.OperationKind == MobileServiceTableOperationKind.Update && error.Result != null)
//                    {   
//                        await error.CancelAndUpdateItemAsync(error.Result);
//                    }
//                    else
//                    { 
//                        await error.CancelAndDiscardItemAsync();
//                    }

//                    Debug.WriteLine(@"Error executing sync operation. Item: {0} ({1}). Operation discarded.", error.TableName, error.Item["id"]);
//                }
//            }
//        }
//#endif
  }
}
