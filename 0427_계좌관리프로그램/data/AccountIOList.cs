using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427_계좌관리프로그램
{
    //WPC의 바인딩 시스템에 변경 사실 알림기능 + List기능
    //ObservableCollection<Account>
    internal class AccountIOList : List<AccountIO>
    {
        public AccountIOList()
        {
            this.Add(new AccountIO(1111, 1000, 0, 1000));
            this.Add(new AccountIO(2222, 1000, 0, 1000));
            this.Add(new AccountIO(3333, 1000, 0, 1000));
        }
    }
}
