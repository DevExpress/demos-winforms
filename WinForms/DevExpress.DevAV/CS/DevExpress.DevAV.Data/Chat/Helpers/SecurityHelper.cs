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

namespace DevExpress.DevAV.Chat.Internal {
	using System;
	using System.Security.Cryptography;
	using DevExpress.Data.Utils.Security;
	static class SecurityHelper {
		public static string GetSalt(int length = 64) {
			byte[] saltBytes = StrongRandom.GetNonZeroBytes(length);
			return Convert.ToBase64String(saltBytes);
		}
		public static string GetHash(string password, string salt, int iterationCount = 1024) {
			byte[] saltBytes = Convert.FromBase64String(salt);
			using(var pbkdf2 = new Rfc2898DeriveBytes(password ?? string.Empty, saltBytes,
				iterations: iterationCount, hashAlgorithm: HashAlgorithmName.SHA512)) {
				return Convert.ToBase64String(pbkdf2.GetBytes(32));
			}
		}
	}
}
