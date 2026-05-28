using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Utils.Serializing;
using System.Collections.Specialized;
using System.Collections;
using System.Drawing;
using System.IO;

namespace PhotoViewer {
    public class PhotoViewerData: IXtraSerializable {
        PathCollection foldersCore;
        AlbumCollection albumsCore;
        AlbumData othersCore;

        bool firstRunCore;

        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true, false, true, 1, XtraSerializationFlags.DeserializeCollectionItemBeforeCallSetIndex)]
        public AlbumCollection Albums {
            get {
                if(albumsCore == null)
                    albumsCore = new AlbumCollection();
                return albumsCore;
            }
        }
        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true, false, true, 2, XtraSerializationFlags.DeserializeCollectionItemBeforeCallSetIndex)]
        public PathCollection Folders {
            get {
                if(foldersCore == null)
                    foldersCore = new PathCollection();
                return foldersCore;
            }
        }
        [XtraSerializableProperty(XtraSerializationVisibility.Content)]
        public AlbumData Others {
            get {
                if(othersCore == null)
                    othersCore = new AlbumData();
                return othersCore;
            }
        }
        [XtraSerializableProperty]
        public bool FirstRun {
            get { return firstRunCore; }
            set { firstRunCore = value; }
        }

        #region IXtraSerializable Members

        void IXtraSerializable.OnEndDeserializing(string restoredVersion) { }
        void IXtraSerializable.OnEndSerializing() { }
        void IXtraSerializable.OnStartDeserializing(DevExpress.Utils.LayoutAllowEventArgs e) { }
        void IXtraSerializable.OnStartSerializing() { }

        #endregion

        public void SaveLayoutToXml(string fileName) {
            if(File.Exists(fileName))
                File.SetAttributes(fileName, FileAttributes.Normal);
            SaveLayoutCore(new XmlXtraSerializer(), fileName);
        }
        public void RestoreLayoutFromXml(string fileName) {
            File.SetAttributes(fileName, FileAttributes.Normal);
            RestoreLayoutCore(new XmlXtraSerializer(), fileName);
        }
        protected virtual bool SaveLayoutCore(XtraSerializer serializer, object path) {
            System.IO.Stream stream = path as System.IO.Stream;
            if(stream != null)
                return serializer.SerializeObjects(
                    new XtraObjectInfo[] { new XtraObjectInfo("PhotoViewerData", this) },
                                             stream, this.GetType().Name);
            else
                return serializer.SerializeObjects(
                    new XtraObjectInfo[] { new XtraObjectInfo("PhotoViewerData", this) },
                                            path.ToString(), this.GetType().Name);
        }
        protected virtual void RestoreLayoutCore(XtraSerializer serializer, object path) {
            System.IO.Stream stream = path as System.IO.Stream;
                if(stream != null)
                    serializer.DeserializeObjects(new XtraObjectInfo[] { new XtraObjectInfo("PhotoViewerData", this) },
                        stream, this.GetType().Name);
                else
                    serializer.DeserializeObjects(new XtraObjectInfo[] { new XtraObjectInfo("PhotoViewerData", this) },
                        path.ToString(), this.GetType().Name);
        }
        object XtraCreateAlbumsItem(XtraItemEventArgs e) {
            return new AlbumData();
        }
        void XtraSetIndexAlbumsItem(XtraSetItemIndexEventArgs e) {
            Albums.Insert(e.NewIndex, (AlbumData)e.Item.Value);
        }
        object XtraCreateFoldersItem(XtraItemEventArgs e) {
            return new PathData();
        }
        void XtraSetIndexFoldersItem(XtraSetItemIndexEventArgs e) {
            Folders.Insert(e.NewIndex, (PathData)e.Item.Value);
        }

        public void Clear() {
            Albums.Clear();
            Folders.Clear();
        }
    }

    public class AlbumCollection : CollectionBase {
        public int Add(AlbumData album) { return List.Add(album); }
        public void Insert(int index, AlbumData album) { List.Insert(index, album); }
        public void Remove(AlbumData album) { List.Remove(album); }
        public AlbumData this[int index] { get { return List[index] as AlbumData; } set { List[index] = value; } }
    }

    public class PathCollection : CollectionBase {
        public int Add(PathData path) { return List.Add(path); }
        public void Insert(int index, PathData path) { List.Insert(index, path); }
        public void Remove(PathData path) { List.Remove(path); }
        public void Remove(string path) {
            foreach(PathData pData in this) {
                if(pData.Path == path) {
                    Remove(pData);
                    return;
                }
            }
        }
        public PathData this[int index] { get { return List[index] as PathData; } set { List[index] = value; } }
        public bool Contains(string file) {
            foreach(PathData pData in this) {
                if(pData.Path == file)
                    return true;
            }
            return false;
        }
    }
    
    public class AlbumData : IXtraSerializable {
        PathCollection filesCore;
        DateTime dateCore;
        string nameCore;
        string descriptionCore;

        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true, false, true, 1, XtraSerializationFlags.DeserializeCollectionItemBeforeCallSetIndex)]
        public PathCollection Files {
            get {
                if(filesCore == null)
                    filesCore = new PathCollection();
                return filesCore;
            }
        }

        [XtraSerializableProperty]
        public string Name { get { return nameCore; } set { nameCore = value; } }
        [XtraSerializableProperty]
        public DateTime Date { get { return dateCore; } set { dateCore = value; } }
        [XtraSerializableProperty]
        public string Description { get { return descriptionCore; } set { descriptionCore = value; } }

        #region IXtraSerializable Members

        void IXtraSerializable.OnEndDeserializing(string restoredVersion) { }
        void IXtraSerializable.OnEndSerializing() { }
        void IXtraSerializable.OnStartDeserializing(DevExpress.Utils.LayoutAllowEventArgs e) { }
        void IXtraSerializable.OnStartSerializing() { }

        #endregion

        object XtraCreateFilesItem(XtraItemEventArgs e) {
            return new PathData();
        }
        void XtraSetIndexFilesItem(XtraSetItemIndexEventArgs e) {
            Files.Insert(e.NewIndex, (PathData)e.Item.Value);
        }
    }

    public class PathData : IXtraSerializable {
        string nameCore;
        string pathCore;
        Image imageCore;

        [XtraSerializableProperty]
        public string Name { get { return nameCore; } set { nameCore = value; } }
        [XtraSerializableProperty]
        public string Path { get { return pathCore; } set { pathCore = value; } }
        public Image Image { get { return imageCore; } set { imageCore = value; } }

        #region IXtraSerializable Members

        void IXtraSerializable.OnEndDeserializing(string restoredVersion) { }
        void IXtraSerializable.OnEndSerializing() { }
        void IXtraSerializable.OnStartDeserializing(DevExpress.Utils.LayoutAllowEventArgs e) { }
        void IXtraSerializable.OnStartSerializing() { }

        #endregion
    }
}
