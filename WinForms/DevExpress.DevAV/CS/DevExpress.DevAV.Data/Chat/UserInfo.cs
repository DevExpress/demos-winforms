#region Copyright (c) 2000-2026 Developer Express Inc.
/*
{*******************************************************************}
{                                                                   }
{       Developer Express .NET Component Library                    }
{                                                                   }
{                                                                   }
{       Copyright (c) 2000-2026 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
#endregion Copyright (c) 2000-2026 Developer Express Inc.

namespace DevExpress.DevAV.Chat.Model {
	using System;
	using System.Collections.Concurrent;
	using System.Drawing;
	using DevExpress.DevAV;
	public class UserInfo : IEquatable<UserInfo> {
		public UserInfo(Employee employee) {
			this.Id = employee.Id;
			this.Name = employee.FullName;
			this.Photo = CreatePhoto(employee.Id, employee.Photo);
			this.MobilePhone = employee.MobilePhone;
			this.Email = employee.Email;
		}
		public long Id {
			get;
			private set;
		}
		public string Name {
			get;
			private set;
		}
		public Image Photo {
			get;
			private set;
		}
		public string MobilePhone {
			get;
			private set;
		}
		public string Email {
			get;
			private set;
		}
		public bool Equals(UserInfo other) {
			return (other != null) && Id == other.Id;
		}
		public override bool Equals(object obj) {
			return Equals(obj as UserInfo);
		}
		public override int GetHashCode() {
			return DevExpress.Utils.HashCodeHelper.CalculateGeneric(Id);
		}
		readonly static ConcurrentDictionary<long, Image> photos = new ConcurrentDictionary<long, Image>();
		static Image CreatePhoto(long id, Image image) {
			return photos.GetOrAdd(id, x => Internal.ImageHelper.ClipImage(image, 256));
		}
	}
}
namespace DevExpress.Data.Utils.Security {
	using System.Security.Cryptography;
	public abstract class SensitiveData {
		public static SensitiveData CreateForCurrentUser() {
			return new CurrentUserSensitiveData();
		}
		public static SensitiveData CreateForLocalMachine() {
			return new LocalMachineSensitiveData();
		}
		readonly static byte[] DefaultEntropy = new byte[20];
		static SensitiveData() {
			StrongRandom.NextBytes(DefaultEntropy);
		}
		SensitiveData() { }
		byte[] protectedData;
		public string Text {
			get {
				if(protectedData == null)
					return null;
				byte[] plainText = ProtectedData.Unprotect(protectedData, GetEntropy(), GetScope());
				return System.Text.Encoding.UTF8.GetString(plainText);
			}
			set {
				if(string.IsNullOrEmpty(value))
					protectedData = null;
				else {
					byte[] plainText = System.Text.Encoding.UTF8.GetBytes(value);
					protectedData = ProtectedData.Protect(plainText, GetEntropy(), GetScope());
				}
			}
		}
		protected virtual byte[] GetEntropy() => DefaultEntropy;
		protected abstract DataProtectionScope GetScope();
		sealed class CurrentUserSensitiveData : SensitiveData {
			protected sealed override DataProtectionScope GetScope() {
				return DataProtectionScope.CurrentUser;
			}
		}
		sealed class LocalMachineSensitiveData : SensitiveData {
			protected sealed override DataProtectionScope GetScope() {
				return DataProtectionScope.LocalMachine;
			}
		}
	}
}
