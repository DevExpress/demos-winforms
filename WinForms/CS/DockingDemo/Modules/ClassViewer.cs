using System;
using System.Reflection;
using DevExpress.XtraTreeList;

namespace DevExpress.Demos {
	public class ClassViewer {
		public static void AddClassInfo(TreeList tv, Type type, object[] objects) {
			string s = type.Assembly.FullName;
			s = s.Substring(0, s.IndexOf(", "));
			int aNode = tv.AppendNode(new object[] {s}, -1, -1, -1, 0).Id;
			foreach(object obj in objects) {
				s = obj.ToString();
				AddMetods(obj.GetType(), tv.AppendNode(new object[] {s}, aNode, -1, -1, 1).Id, tv);
			}
			tv.ExpandAll();
		}
		static void AddMetods(Type type, int node, TreeList tv) {
			MemberInfo[] mii = type.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
			foreach(MemberInfo mi in mii) {
				int ind = GetImageIndex(mi.MemberType);
				if(ind != -1) ind += GetAccessType(mi);
                tv.AppendNode(new object[] { mi.ToString() }, node, -1, -1, ind);
			}
		}
		static int GetImageIndex(MemberTypes type) {
			switch(type.ToString()) {
				case "Field": 
				case "Property": 
					return 2;
				case "Event": 
					return 3;
				case "Method": 
				case "Constructor":
					return 4;
				default: 
					return -1;
			}
		} 
		static int GetAccessType(MemberInfo m) {
			int x = 3;
			MethodInfo mi = GetMethodInfo(m);
			int ret = x * 2;
			if(m is EventInfo) 
				mi = (m as EventInfo).GetAddMethod(true);
			if(mi != null) {
				if(mi.IsPublic) ret = 0;
				if(mi.IsPrivate) ret = x;
			}
			if(m is FieldInfo) { 
				if((m as FieldInfo).IsPublic) ret = 0;
				if((m as FieldInfo).IsPrivate) ret = x;
			}
			if(m is ConstructorInfo) {
				if((m as ConstructorInfo).IsPublic) ret = 0;
				if((m as ConstructorInfo).IsPrivate) ret = x;
			}
			return ret;
		}
		static MethodInfo GetMethodInfo(MemberInfo m) {
			if(m is PropertyInfo) {
				PropertyInfo pi = m as PropertyInfo;
				m = pi.GetGetMethod();
				if(m == null) m = pi.GetGetMethod(true);
			}
			if(m is MethodInfo) 
				return m as MethodInfo;
			return null;
		}
	}
}
