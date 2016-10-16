using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUMgmt {
    class ADUM_Division {
        public ADUM_Division Parent { get; private set; }
        public ADUM_Room Room { get; private set; }

        public string FullName { get; private set; }
        public string ShortlName { get; private set; }

        public string LDAPCN { get { return "CN="; } }
        public string LDAPOU { get { return "OU="; } }

        public ADUM_Division(ADUM_Room room, string fullName, string shortName = "", ADUM_Division parent = null) {
            SetParent(parent);
            SetRoom(room);
            SetFullName(fullName);
            SetShortName(shortName);
        }

        public void SetParent(ADUM_Division parent) {
            if (parent != null)
                this.Parent = parent;
        }
        public void SetRoom(ADUM_Room room) {
            if (room != null)
                this.Room = room;
        }
        public void SetFullName(string fullName) {
            if (fullName != "")
                this.FullName = fullName;
        }
        public void SetShortName(string shortName = "") {
            if (shortName != "")
                if (shortName.Length < 64)
                    this.ShortlName = shortName;
                else
                    this.ShortlName = shortName.Substring(0, 63);
            else
                SetShortName(this.FullName);
        }
        public void ResetShortName() {
            SetShortName(this.FullName);
        }
    }
}
