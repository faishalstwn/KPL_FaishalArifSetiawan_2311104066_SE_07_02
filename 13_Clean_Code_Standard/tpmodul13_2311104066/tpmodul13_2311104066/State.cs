﻿namespace tpmodul13_2311104066
{
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();
        public abstract void Handle2();
    }
}
