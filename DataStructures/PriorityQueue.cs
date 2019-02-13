// ported and changed a bit from Java implementation of IndexMinPQ here: https://algs4.cs.princeton.edu/43mst/IndexMinPQ.java.html
using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    public class IndexMinPQ<Key> where Key: IComparable
    {
        public int Count => _n;
        public bool isEmpty => _n == 0;

        private int _maxN;        // maximum number of elements on PQ
        private int _n;           // number of elements on PQ
        private int[] _pq;        // binary heap using 1-based indexing
        private int[] _qp;        // inverse of pq - qp[pq[i]] = pq[qp[i]] = i
        private Key[] _keys;      // keys[i] = priority of i

        public IndexMinPQ(int maxN) 
        {
            if (maxN < 0) throw new ArgumentException(nameof(maxN));
            _maxN = maxN;
            _n = 0;
            _keys = new Key[maxN + 1];
            _pq   = new int[maxN + 1];
            _qp   = new int[maxN + 1];                   
            
            for (int i = 0; i <= maxN; i++) _qp[i] = -1;
        }

        public bool Contains(int i) 
        {
            if (i < 0 || i >= _maxN) throw new ArgumentException(nameof(i));
            return _qp[i] != -1;
        }

        public void Insert(int i, Key key) 
        {
            if (i < 0 || i >= _maxN) throw new ArgumentException(nameof(i));
            if (Contains(i)) throw new ArgumentException(nameof(i), "index is already in the priority queue");
            _n++;
            _qp[i] = _n;
            _pq[_n] = i;
            _keys[i] = key;
            Swim(_n);
        }

        public int DelMin() {
            if (_n == 0) throw new ArgumentException("Priority queue underflow");
            int min = _pq[1];
            Exch(1, _n--);
            Sink(1);
            _qp[min] = -1;        // delete            
            _pq[_n+1] = -1;        // not needed
            return min;
        }

        public void DecreaseKey(int i, Key key) 
        {
            if (i < 0 || i >= _maxN) throw new ArgumentException(nameof(i));
            if (!Contains(i)) throw new ArgumentException("index is not in the priority queue");
            if (_keys[i].CompareTo(key) <= 0)
                throw new ArgumentException("Calling decreaseKey() with given argument would not strictly decrease the key");
            _keys[i] = key;
            Swim(_qp[i]);
        }

        private bool Greater(int i, int j) {
            return _keys[_pq[i]].CompareTo(_keys[_pq[j]]) > 0;
        }

        private void Exch(int i, int j) 
        {
            int swap = _pq[i];
            _pq[i] = _pq[j];
            _pq[j] = swap;
            _qp[_pq[i]] = i;
            _qp[_pq[j]] = j;
        }

        private void Swim(int k) 
        {
            while (k > 1 && Greater(k/2, k)) {
                Exch(k, k/2);
                k = k/2;
            }
        }

        private void Sink(int k) 
        {
            while (2*k <= _n) {
                int j = 2*k;
                if (j < _n && Greater(j, j+1)) j++;
                if (!Greater(k, j)) break;
                Exch(k, j);
                k = j;
            }
        }
    }
}
