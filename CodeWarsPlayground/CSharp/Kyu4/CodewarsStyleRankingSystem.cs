using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu4
{
    public class CodewarsStyleRankingSystem
    {
        public class User
        {
            public int rank;
            public int progress;

            public User()
            {
                rank = 1;
                progress = 0;
            }

            public void incProgress(int actRank)
            {
                ValidateRank(actRank);
                this.progress += calculateProgress(actRank);
                var currentProggres = this.progress;
                if (this.progress > 100)
                {
                    AddRank();
                }
                var currentRank = this.rank;
            }

            private void AddRank()
            {
                var tmp = this.progress / 100;

                switch (this.rank)
                {
                    case >= 8:
                    case -1:
                        {
                            if (tmp >= 8)
                            {
                                this.rank = 8;
                                this.progress = 0;
                            }
                            else
                                this.rank += (tmp + 1);
                            break;
                        }
                    default:
                        this.rank += tmp;
                        if (this.rank == 0)
                        {
                            this.rank++;
                        }
                        break;
                }
                this.progress -= tmp * 100;

            }

            private int calculateProgress(int actRank)
            {
                int rank = this.rank;
                if (actRank == 0)
                {
                    return 3;
                }
                if (actRank < 0)
                {
                    if (this.rank < 0)
                    {
                        if (Math.Abs(this.rank - actRank) == 1 && this.rank > actRank)
                            return 1;
                        if (Math.Abs(this.rank - actRank) >= 2 && this.rank > actRank)
                            return 0;
                        else
                            return 10 * Math.Abs(this.rank - actRank) * Math.Abs(this.rank - actRank);
                    }
                    else
                    {
                        if (Math.Abs(this.rank - actRank - 1) == 1 && this.rank > actRank)
                            return 1;
                        if (Math.Abs(this.rank - actRank - 1) >= 2 && this.rank > actRank)
                            return 0;
                    }
                }
                else
                {
                    if (this.rank < 0)
                    {
                        if (Math.Abs(this.rank - actRank + 1) == 1 && this.rank > actRank)
                            return 1;
                        if (Math.Abs(this.rank - actRank + 1) >= 2 && this.rank > actRank)
                        return 0;
                        else
                        return 10 * Math.Abs(this.rank - actRank + 1) * Math.Abs(this.rank - actRank + 1);
                    }
                    else
                    {
                        if (Math.Abs(this.rank - actRank) == 1 && this.rank > actRank)
                            return 1;
                        if (Math.Abs(this.rank - actRank) >= 2 && this.rank > actRank)
                            return 0;
                        else
                        return 10 * Math.Abs(this.rank - actRank) * Math.Abs(this.rank - actRank);
                    }
                }
                return 0; //Unexpected
            }
        }

        private static void ValidateRank(int rank)
        {
            switch (rank)
            {
                case 0:
                    throw new ArgumentException();
                case > 8:
                    throw new ArgumentException();
                case < -8:
                    throw new ArgumentException();
            }
        }

        }
    }
}