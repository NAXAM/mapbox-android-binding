namespace Com.Mapbox.Android.Core
{
    public partial class FileUtils
    {
        public partial class LastModifiedComparator
        {
            public int Compare(Java.Lang.Object o1, Java.Lang.Object o2)
            {
                return Compare(o1 as global::Java.IO.File, o2 as global::Java.IO.File);
            }
        }
    }
}
