using System;
using System.Collections;
using System.Collections.Generic;

namespace OptimizedList
{
	public struct CapacityLimitedList1<T> : IList<T> {
		int _count;
		T _v0;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 1) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 1) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList2<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 2) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 2) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList4<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 4) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 4) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList8<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;
		T _v4;
		T _v5;
		T _v6;
		T _v7;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			case 4: return _v4;
			case 5: return _v5;
			case 6: return _v6;
			case 7: return _v7;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			case 4: _v4 = value; return;
			case 5: _v5 = value; return;
			case 6: _v6 = value; return;
			case 7: _v7 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 8) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 8) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList16<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;
		T _v4;
		T _v5;
		T _v6;
		T _v7;
		T _v8;
		T _v9;
		T _v10;
		T _v11;
		T _v12;
		T _v13;
		T _v14;
		T _v15;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			case 4: return _v4;
			case 5: return _v5;
			case 6: return _v6;
			case 7: return _v7;
			case 8: return _v8;
			case 9: return _v9;
			case 10: return _v10;
			case 11: return _v11;
			case 12: return _v12;
			case 13: return _v13;
			case 14: return _v14;
			case 15: return _v15;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			case 4: _v4 = value; return;
			case 5: _v5 = value; return;
			case 6: _v6 = value; return;
			case 7: _v7 = value; return;
			case 8: _v8 = value; return;
			case 9: _v9 = value; return;
			case 10: _v10 = value; return;
			case 11: _v11 = value; return;
			case 12: _v12 = value; return;
			case 13: _v13 = value; return;
			case 14: _v14 = value; return;
			case 15: _v15 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 16) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 16) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList32<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;
		T _v4;
		T _v5;
		T _v6;
		T _v7;
		T _v8;
		T _v9;
		T _v10;
		T _v11;
		T _v12;
		T _v13;
		T _v14;
		T _v15;
		T _v16;
		T _v17;
		T _v18;
		T _v19;
		T _v20;
		T _v21;
		T _v22;
		T _v23;
		T _v24;
		T _v25;
		T _v26;
		T _v27;
		T _v28;
		T _v29;
		T _v30;
		T _v31;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			case 4: return _v4;
			case 5: return _v5;
			case 6: return _v6;
			case 7: return _v7;
			case 8: return _v8;
			case 9: return _v9;
			case 10: return _v10;
			case 11: return _v11;
			case 12: return _v12;
			case 13: return _v13;
			case 14: return _v14;
			case 15: return _v15;
			case 16: return _v16;
			case 17: return _v17;
			case 18: return _v18;
			case 19: return _v19;
			case 20: return _v20;
			case 21: return _v21;
			case 22: return _v22;
			case 23: return _v23;
			case 24: return _v24;
			case 25: return _v25;
			case 26: return _v26;
			case 27: return _v27;
			case 28: return _v28;
			case 29: return _v29;
			case 30: return _v30;
			case 31: return _v31;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			case 4: _v4 = value; return;
			case 5: _v5 = value; return;
			case 6: _v6 = value; return;
			case 7: _v7 = value; return;
			case 8: _v8 = value; return;
			case 9: _v9 = value; return;
			case 10: _v10 = value; return;
			case 11: _v11 = value; return;
			case 12: _v12 = value; return;
			case 13: _v13 = value; return;
			case 14: _v14 = value; return;
			case 15: _v15 = value; return;
			case 16: _v16 = value; return;
			case 17: _v17 = value; return;
			case 18: _v18 = value; return;
			case 19: _v19 = value; return;
			case 20: _v20 = value; return;
			case 21: _v21 = value; return;
			case 22: _v22 = value; return;
			case 23: _v23 = value; return;
			case 24: _v24 = value; return;
			case 25: _v25 = value; return;
			case 26: _v26 = value; return;
			case 27: _v27 = value; return;
			case 28: _v28 = value; return;
			case 29: _v29 = value; return;
			case 30: _v30 = value; return;
			case 31: _v31 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 32) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 32) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList64<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;
		T _v4;
		T _v5;
		T _v6;
		T _v7;
		T _v8;
		T _v9;
		T _v10;
		T _v11;
		T _v12;
		T _v13;
		T _v14;
		T _v15;
		T _v16;
		T _v17;
		T _v18;
		T _v19;
		T _v20;
		T _v21;
		T _v22;
		T _v23;
		T _v24;
		T _v25;
		T _v26;
		T _v27;
		T _v28;
		T _v29;
		T _v30;
		T _v31;
		T _v32;
		T _v33;
		T _v34;
		T _v35;
		T _v36;
		T _v37;
		T _v38;
		T _v39;
		T _v40;
		T _v41;
		T _v42;
		T _v43;
		T _v44;
		T _v45;
		T _v46;
		T _v47;
		T _v48;
		T _v49;
		T _v50;
		T _v51;
		T _v52;
		T _v53;
		T _v54;
		T _v55;
		T _v56;
		T _v57;
		T _v58;
		T _v59;
		T _v60;
		T _v61;
		T _v62;
		T _v63;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			case 4: return _v4;
			case 5: return _v5;
			case 6: return _v6;
			case 7: return _v7;
			case 8: return _v8;
			case 9: return _v9;
			case 10: return _v10;
			case 11: return _v11;
			case 12: return _v12;
			case 13: return _v13;
			case 14: return _v14;
			case 15: return _v15;
			case 16: return _v16;
			case 17: return _v17;
			case 18: return _v18;
			case 19: return _v19;
			case 20: return _v20;
			case 21: return _v21;
			case 22: return _v22;
			case 23: return _v23;
			case 24: return _v24;
			case 25: return _v25;
			case 26: return _v26;
			case 27: return _v27;
			case 28: return _v28;
			case 29: return _v29;
			case 30: return _v30;
			case 31: return _v31;
			case 32: return _v32;
			case 33: return _v33;
			case 34: return _v34;
			case 35: return _v35;
			case 36: return _v36;
			case 37: return _v37;
			case 38: return _v38;
			case 39: return _v39;
			case 40: return _v40;
			case 41: return _v41;
			case 42: return _v42;
			case 43: return _v43;
			case 44: return _v44;
			case 45: return _v45;
			case 46: return _v46;
			case 47: return _v47;
			case 48: return _v48;
			case 49: return _v49;
			case 50: return _v50;
			case 51: return _v51;
			case 52: return _v52;
			case 53: return _v53;
			case 54: return _v54;
			case 55: return _v55;
			case 56: return _v56;
			case 57: return _v57;
			case 58: return _v58;
			case 59: return _v59;
			case 60: return _v60;
			case 61: return _v61;
			case 62: return _v62;
			case 63: return _v63;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			case 4: _v4 = value; return;
			case 5: _v5 = value; return;
			case 6: _v6 = value; return;
			case 7: _v7 = value; return;
			case 8: _v8 = value; return;
			case 9: _v9 = value; return;
			case 10: _v10 = value; return;
			case 11: _v11 = value; return;
			case 12: _v12 = value; return;
			case 13: _v13 = value; return;
			case 14: _v14 = value; return;
			case 15: _v15 = value; return;
			case 16: _v16 = value; return;
			case 17: _v17 = value; return;
			case 18: _v18 = value; return;
			case 19: _v19 = value; return;
			case 20: _v20 = value; return;
			case 21: _v21 = value; return;
			case 22: _v22 = value; return;
			case 23: _v23 = value; return;
			case 24: _v24 = value; return;
			case 25: _v25 = value; return;
			case 26: _v26 = value; return;
			case 27: _v27 = value; return;
			case 28: _v28 = value; return;
			case 29: _v29 = value; return;
			case 30: _v30 = value; return;
			case 31: _v31 = value; return;
			case 32: _v32 = value; return;
			case 33: _v33 = value; return;
			case 34: _v34 = value; return;
			case 35: _v35 = value; return;
			case 36: _v36 = value; return;
			case 37: _v37 = value; return;
			case 38: _v38 = value; return;
			case 39: _v39 = value; return;
			case 40: _v40 = value; return;
			case 41: _v41 = value; return;
			case 42: _v42 = value; return;
			case 43: _v43 = value; return;
			case 44: _v44 = value; return;
			case 45: _v45 = value; return;
			case 46: _v46 = value; return;
			case 47: _v47 = value; return;
			case 48: _v48 = value; return;
			case 49: _v49 = value; return;
			case 50: _v50 = value; return;
			case 51: _v51 = value; return;
			case 52: _v52 = value; return;
			case 53: _v53 = value; return;
			case 54: _v54 = value; return;
			case 55: _v55 = value; return;
			case 56: _v56 = value; return;
			case 57: _v57 = value; return;
			case 58: _v58 = value; return;
			case 59: _v59 = value; return;
			case 60: _v60 = value; return;
			case 61: _v61 = value; return;
			case 62: _v62 = value; return;
			case 63: _v63 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 64) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 64) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList128<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;
		T _v4;
		T _v5;
		T _v6;
		T _v7;
		T _v8;
		T _v9;
		T _v10;
		T _v11;
		T _v12;
		T _v13;
		T _v14;
		T _v15;
		T _v16;
		T _v17;
		T _v18;
		T _v19;
		T _v20;
		T _v21;
		T _v22;
		T _v23;
		T _v24;
		T _v25;
		T _v26;
		T _v27;
		T _v28;
		T _v29;
		T _v30;
		T _v31;
		T _v32;
		T _v33;
		T _v34;
		T _v35;
		T _v36;
		T _v37;
		T _v38;
		T _v39;
		T _v40;
		T _v41;
		T _v42;
		T _v43;
		T _v44;
		T _v45;
		T _v46;
		T _v47;
		T _v48;
		T _v49;
		T _v50;
		T _v51;
		T _v52;
		T _v53;
		T _v54;
		T _v55;
		T _v56;
		T _v57;
		T _v58;
		T _v59;
		T _v60;
		T _v61;
		T _v62;
		T _v63;
		T _v64;
		T _v65;
		T _v66;
		T _v67;
		T _v68;
		T _v69;
		T _v70;
		T _v71;
		T _v72;
		T _v73;
		T _v74;
		T _v75;
		T _v76;
		T _v77;
		T _v78;
		T _v79;
		T _v80;
		T _v81;
		T _v82;
		T _v83;
		T _v84;
		T _v85;
		T _v86;
		T _v87;
		T _v88;
		T _v89;
		T _v90;
		T _v91;
		T _v92;
		T _v93;
		T _v94;
		T _v95;
		T _v96;
		T _v97;
		T _v98;
		T _v99;
		T _v100;
		T _v101;
		T _v102;
		T _v103;
		T _v104;
		T _v105;
		T _v106;
		T _v107;
		T _v108;
		T _v109;
		T _v110;
		T _v111;
		T _v112;
		T _v113;
		T _v114;
		T _v115;
		T _v116;
		T _v117;
		T _v118;
		T _v119;
		T _v120;
		T _v121;
		T _v122;
		T _v123;
		T _v124;
		T _v125;
		T _v126;
		T _v127;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			case 4: return _v4;
			case 5: return _v5;
			case 6: return _v6;
			case 7: return _v7;
			case 8: return _v8;
			case 9: return _v9;
			case 10: return _v10;
			case 11: return _v11;
			case 12: return _v12;
			case 13: return _v13;
			case 14: return _v14;
			case 15: return _v15;
			case 16: return _v16;
			case 17: return _v17;
			case 18: return _v18;
			case 19: return _v19;
			case 20: return _v20;
			case 21: return _v21;
			case 22: return _v22;
			case 23: return _v23;
			case 24: return _v24;
			case 25: return _v25;
			case 26: return _v26;
			case 27: return _v27;
			case 28: return _v28;
			case 29: return _v29;
			case 30: return _v30;
			case 31: return _v31;
			case 32: return _v32;
			case 33: return _v33;
			case 34: return _v34;
			case 35: return _v35;
			case 36: return _v36;
			case 37: return _v37;
			case 38: return _v38;
			case 39: return _v39;
			case 40: return _v40;
			case 41: return _v41;
			case 42: return _v42;
			case 43: return _v43;
			case 44: return _v44;
			case 45: return _v45;
			case 46: return _v46;
			case 47: return _v47;
			case 48: return _v48;
			case 49: return _v49;
			case 50: return _v50;
			case 51: return _v51;
			case 52: return _v52;
			case 53: return _v53;
			case 54: return _v54;
			case 55: return _v55;
			case 56: return _v56;
			case 57: return _v57;
			case 58: return _v58;
			case 59: return _v59;
			case 60: return _v60;
			case 61: return _v61;
			case 62: return _v62;
			case 63: return _v63;
			case 64: return _v64;
			case 65: return _v65;
			case 66: return _v66;
			case 67: return _v67;
			case 68: return _v68;
			case 69: return _v69;
			case 70: return _v70;
			case 71: return _v71;
			case 72: return _v72;
			case 73: return _v73;
			case 74: return _v74;
			case 75: return _v75;
			case 76: return _v76;
			case 77: return _v77;
			case 78: return _v78;
			case 79: return _v79;
			case 80: return _v80;
			case 81: return _v81;
			case 82: return _v82;
			case 83: return _v83;
			case 84: return _v84;
			case 85: return _v85;
			case 86: return _v86;
			case 87: return _v87;
			case 88: return _v88;
			case 89: return _v89;
			case 90: return _v90;
			case 91: return _v91;
			case 92: return _v92;
			case 93: return _v93;
			case 94: return _v94;
			case 95: return _v95;
			case 96: return _v96;
			case 97: return _v97;
			case 98: return _v98;
			case 99: return _v99;
			case 100: return _v100;
			case 101: return _v101;
			case 102: return _v102;
			case 103: return _v103;
			case 104: return _v104;
			case 105: return _v105;
			case 106: return _v106;
			case 107: return _v107;
			case 108: return _v108;
			case 109: return _v109;
			case 110: return _v110;
			case 111: return _v111;
			case 112: return _v112;
			case 113: return _v113;
			case 114: return _v114;
			case 115: return _v115;
			case 116: return _v116;
			case 117: return _v117;
			case 118: return _v118;
			case 119: return _v119;
			case 120: return _v120;
			case 121: return _v121;
			case 122: return _v122;
			case 123: return _v123;
			case 124: return _v124;
			case 125: return _v125;
			case 126: return _v126;
			case 127: return _v127;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			case 4: _v4 = value; return;
			case 5: _v5 = value; return;
			case 6: _v6 = value; return;
			case 7: _v7 = value; return;
			case 8: _v8 = value; return;
			case 9: _v9 = value; return;
			case 10: _v10 = value; return;
			case 11: _v11 = value; return;
			case 12: _v12 = value; return;
			case 13: _v13 = value; return;
			case 14: _v14 = value; return;
			case 15: _v15 = value; return;
			case 16: _v16 = value; return;
			case 17: _v17 = value; return;
			case 18: _v18 = value; return;
			case 19: _v19 = value; return;
			case 20: _v20 = value; return;
			case 21: _v21 = value; return;
			case 22: _v22 = value; return;
			case 23: _v23 = value; return;
			case 24: _v24 = value; return;
			case 25: _v25 = value; return;
			case 26: _v26 = value; return;
			case 27: _v27 = value; return;
			case 28: _v28 = value; return;
			case 29: _v29 = value; return;
			case 30: _v30 = value; return;
			case 31: _v31 = value; return;
			case 32: _v32 = value; return;
			case 33: _v33 = value; return;
			case 34: _v34 = value; return;
			case 35: _v35 = value; return;
			case 36: _v36 = value; return;
			case 37: _v37 = value; return;
			case 38: _v38 = value; return;
			case 39: _v39 = value; return;
			case 40: _v40 = value; return;
			case 41: _v41 = value; return;
			case 42: _v42 = value; return;
			case 43: _v43 = value; return;
			case 44: _v44 = value; return;
			case 45: _v45 = value; return;
			case 46: _v46 = value; return;
			case 47: _v47 = value; return;
			case 48: _v48 = value; return;
			case 49: _v49 = value; return;
			case 50: _v50 = value; return;
			case 51: _v51 = value; return;
			case 52: _v52 = value; return;
			case 53: _v53 = value; return;
			case 54: _v54 = value; return;
			case 55: _v55 = value; return;
			case 56: _v56 = value; return;
			case 57: _v57 = value; return;
			case 58: _v58 = value; return;
			case 59: _v59 = value; return;
			case 60: _v60 = value; return;
			case 61: _v61 = value; return;
			case 62: _v62 = value; return;
			case 63: _v63 = value; return;
			case 64: _v64 = value; return;
			case 65: _v65 = value; return;
			case 66: _v66 = value; return;
			case 67: _v67 = value; return;
			case 68: _v68 = value; return;
			case 69: _v69 = value; return;
			case 70: _v70 = value; return;
			case 71: _v71 = value; return;
			case 72: _v72 = value; return;
			case 73: _v73 = value; return;
			case 74: _v74 = value; return;
			case 75: _v75 = value; return;
			case 76: _v76 = value; return;
			case 77: _v77 = value; return;
			case 78: _v78 = value; return;
			case 79: _v79 = value; return;
			case 80: _v80 = value; return;
			case 81: _v81 = value; return;
			case 82: _v82 = value; return;
			case 83: _v83 = value; return;
			case 84: _v84 = value; return;
			case 85: _v85 = value; return;
			case 86: _v86 = value; return;
			case 87: _v87 = value; return;
			case 88: _v88 = value; return;
			case 89: _v89 = value; return;
			case 90: _v90 = value; return;
			case 91: _v91 = value; return;
			case 92: _v92 = value; return;
			case 93: _v93 = value; return;
			case 94: _v94 = value; return;
			case 95: _v95 = value; return;
			case 96: _v96 = value; return;
			case 97: _v97 = value; return;
			case 98: _v98 = value; return;
			case 99: _v99 = value; return;
			case 100: _v100 = value; return;
			case 101: _v101 = value; return;
			case 102: _v102 = value; return;
			case 103: _v103 = value; return;
			case 104: _v104 = value; return;
			case 105: _v105 = value; return;
			case 106: _v106 = value; return;
			case 107: _v107 = value; return;
			case 108: _v108 = value; return;
			case 109: _v109 = value; return;
			case 110: _v110 = value; return;
			case 111: _v111 = value; return;
			case 112: _v112 = value; return;
			case 113: _v113 = value; return;
			case 114: _v114 = value; return;
			case 115: _v115 = value; return;
			case 116: _v116 = value; return;
			case 117: _v117 = value; return;
			case 118: _v118 = value; return;
			case 119: _v119 = value; return;
			case 120: _v120 = value; return;
			case 121: _v121 = value; return;
			case 122: _v122 = value; return;
			case 123: _v123 = value; return;
			case 124: _v124 = value; return;
			case 125: _v125 = value; return;
			case 126: _v126 = value; return;
			case 127: _v127 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 128) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 128) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public struct CapacityLimitedList256<T> : IList<T> {
		int _count;
		T _v0;
		T _v1;
		T _v2;
		T _v3;
		T _v4;
		T _v5;
		T _v6;
		T _v7;
		T _v8;
		T _v9;
		T _v10;
		T _v11;
		T _v12;
		T _v13;
		T _v14;
		T _v15;
		T _v16;
		T _v17;
		T _v18;
		T _v19;
		T _v20;
		T _v21;
		T _v22;
		T _v23;
		T _v24;
		T _v25;
		T _v26;
		T _v27;
		T _v28;
		T _v29;
		T _v30;
		T _v31;
		T _v32;
		T _v33;
		T _v34;
		T _v35;
		T _v36;
		T _v37;
		T _v38;
		T _v39;
		T _v40;
		T _v41;
		T _v42;
		T _v43;
		T _v44;
		T _v45;
		T _v46;
		T _v47;
		T _v48;
		T _v49;
		T _v50;
		T _v51;
		T _v52;
		T _v53;
		T _v54;
		T _v55;
		T _v56;
		T _v57;
		T _v58;
		T _v59;
		T _v60;
		T _v61;
		T _v62;
		T _v63;
		T _v64;
		T _v65;
		T _v66;
		T _v67;
		T _v68;
		T _v69;
		T _v70;
		T _v71;
		T _v72;
		T _v73;
		T _v74;
		T _v75;
		T _v76;
		T _v77;
		T _v78;
		T _v79;
		T _v80;
		T _v81;
		T _v82;
		T _v83;
		T _v84;
		T _v85;
		T _v86;
		T _v87;
		T _v88;
		T _v89;
		T _v90;
		T _v91;
		T _v92;
		T _v93;
		T _v94;
		T _v95;
		T _v96;
		T _v97;
		T _v98;
		T _v99;
		T _v100;
		T _v101;
		T _v102;
		T _v103;
		T _v104;
		T _v105;
		T _v106;
		T _v107;
		T _v108;
		T _v109;
		T _v110;
		T _v111;
		T _v112;
		T _v113;
		T _v114;
		T _v115;
		T _v116;
		T _v117;
		T _v118;
		T _v119;
		T _v120;
		T _v121;
		T _v122;
		T _v123;
		T _v124;
		T _v125;
		T _v126;
		T _v127;
		T _v128;
		T _v129;
		T _v130;
		T _v131;
		T _v132;
		T _v133;
		T _v134;
		T _v135;
		T _v136;
		T _v137;
		T _v138;
		T _v139;
		T _v140;
		T _v141;
		T _v142;
		T _v143;
		T _v144;
		T _v145;
		T _v146;
		T _v147;
		T _v148;
		T _v149;
		T _v150;
		T _v151;
		T _v152;
		T _v153;
		T _v154;
		T _v155;
		T _v156;
		T _v157;
		T _v158;
		T _v159;
		T _v160;
		T _v161;
		T _v162;
		T _v163;
		T _v164;
		T _v165;
		T _v166;
		T _v167;
		T _v168;
		T _v169;
		T _v170;
		T _v171;
		T _v172;
		T _v173;
		T _v174;
		T _v175;
		T _v176;
		T _v177;
		T _v178;
		T _v179;
		T _v180;
		T _v181;
		T _v182;
		T _v183;
		T _v184;
		T _v185;
		T _v186;
		T _v187;
		T _v188;
		T _v189;
		T _v190;
		T _v191;
		T _v192;
		T _v193;
		T _v194;
		T _v195;
		T _v196;
		T _v197;
		T _v198;
		T _v199;
		T _v200;
		T _v201;
		T _v202;
		T _v203;
		T _v204;
		T _v205;
		T _v206;
		T _v207;
		T _v208;
		T _v209;
		T _v210;
		T _v211;
		T _v212;
		T _v213;
		T _v214;
		T _v215;
		T _v216;
		T _v217;
		T _v218;
		T _v219;
		T _v220;
		T _v221;
		T _v222;
		T _v223;
		T _v224;
		T _v225;
		T _v226;
		T _v227;
		T _v228;
		T _v229;
		T _v230;
		T _v231;
		T _v232;
		T _v233;
		T _v234;
		T _v235;
		T _v236;
		T _v237;
		T _v238;
		T _v239;
		T _v240;
		T _v241;
		T _v242;
		T _v243;
		T _v244;
		T _v245;
		T _v246;
		T _v247;
		T _v248;
		T _v249;
		T _v250;
		T _v251;
		T _v252;
		T _v253;
		T _v254;
		T _v255;

		void BoundsError() {
			throw new ArgumentOutOfRangeException();
		}
		void CheckBounds(int n) {
			if (n < 0 || n >= _count) BoundsError();
		}

		T GetRaw(int index) {
			switch (index) {
			case 0: return _v0;
			case 1: return _v1;
			case 2: return _v2;
			case 3: return _v3;
			case 4: return _v4;
			case 5: return _v5;
			case 6: return _v6;
			case 7: return _v7;
			case 8: return _v8;
			case 9: return _v9;
			case 10: return _v10;
			case 11: return _v11;
			case 12: return _v12;
			case 13: return _v13;
			case 14: return _v14;
			case 15: return _v15;
			case 16: return _v16;
			case 17: return _v17;
			case 18: return _v18;
			case 19: return _v19;
			case 20: return _v20;
			case 21: return _v21;
			case 22: return _v22;
			case 23: return _v23;
			case 24: return _v24;
			case 25: return _v25;
			case 26: return _v26;
			case 27: return _v27;
			case 28: return _v28;
			case 29: return _v29;
			case 30: return _v30;
			case 31: return _v31;
			case 32: return _v32;
			case 33: return _v33;
			case 34: return _v34;
			case 35: return _v35;
			case 36: return _v36;
			case 37: return _v37;
			case 38: return _v38;
			case 39: return _v39;
			case 40: return _v40;
			case 41: return _v41;
			case 42: return _v42;
			case 43: return _v43;
			case 44: return _v44;
			case 45: return _v45;
			case 46: return _v46;
			case 47: return _v47;
			case 48: return _v48;
			case 49: return _v49;
			case 50: return _v50;
			case 51: return _v51;
			case 52: return _v52;
			case 53: return _v53;
			case 54: return _v54;
			case 55: return _v55;
			case 56: return _v56;
			case 57: return _v57;
			case 58: return _v58;
			case 59: return _v59;
			case 60: return _v60;
			case 61: return _v61;
			case 62: return _v62;
			case 63: return _v63;
			case 64: return _v64;
			case 65: return _v65;
			case 66: return _v66;
			case 67: return _v67;
			case 68: return _v68;
			case 69: return _v69;
			case 70: return _v70;
			case 71: return _v71;
			case 72: return _v72;
			case 73: return _v73;
			case 74: return _v74;
			case 75: return _v75;
			case 76: return _v76;
			case 77: return _v77;
			case 78: return _v78;
			case 79: return _v79;
			case 80: return _v80;
			case 81: return _v81;
			case 82: return _v82;
			case 83: return _v83;
			case 84: return _v84;
			case 85: return _v85;
			case 86: return _v86;
			case 87: return _v87;
			case 88: return _v88;
			case 89: return _v89;
			case 90: return _v90;
			case 91: return _v91;
			case 92: return _v92;
			case 93: return _v93;
			case 94: return _v94;
			case 95: return _v95;
			case 96: return _v96;
			case 97: return _v97;
			case 98: return _v98;
			case 99: return _v99;
			case 100: return _v100;
			case 101: return _v101;
			case 102: return _v102;
			case 103: return _v103;
			case 104: return _v104;
			case 105: return _v105;
			case 106: return _v106;
			case 107: return _v107;
			case 108: return _v108;
			case 109: return _v109;
			case 110: return _v110;
			case 111: return _v111;
			case 112: return _v112;
			case 113: return _v113;
			case 114: return _v114;
			case 115: return _v115;
			case 116: return _v116;
			case 117: return _v117;
			case 118: return _v118;
			case 119: return _v119;
			case 120: return _v120;
			case 121: return _v121;
			case 122: return _v122;
			case 123: return _v123;
			case 124: return _v124;
			case 125: return _v125;
			case 126: return _v126;
			case 127: return _v127;
			case 128: return _v128;
			case 129: return _v129;
			case 130: return _v130;
			case 131: return _v131;
			case 132: return _v132;
			case 133: return _v133;
			case 134: return _v134;
			case 135: return _v135;
			case 136: return _v136;
			case 137: return _v137;
			case 138: return _v138;
			case 139: return _v139;
			case 140: return _v140;
			case 141: return _v141;
			case 142: return _v142;
			case 143: return _v143;
			case 144: return _v144;
			case 145: return _v145;
			case 146: return _v146;
			case 147: return _v147;
			case 148: return _v148;
			case 149: return _v149;
			case 150: return _v150;
			case 151: return _v151;
			case 152: return _v152;
			case 153: return _v153;
			case 154: return _v154;
			case 155: return _v155;
			case 156: return _v156;
			case 157: return _v157;
			case 158: return _v158;
			case 159: return _v159;
			case 160: return _v160;
			case 161: return _v161;
			case 162: return _v162;
			case 163: return _v163;
			case 164: return _v164;
			case 165: return _v165;
			case 166: return _v166;
			case 167: return _v167;
			case 168: return _v168;
			case 169: return _v169;
			case 170: return _v170;
			case 171: return _v171;
			case 172: return _v172;
			case 173: return _v173;
			case 174: return _v174;
			case 175: return _v175;
			case 176: return _v176;
			case 177: return _v177;
			case 178: return _v178;
			case 179: return _v179;
			case 180: return _v180;
			case 181: return _v181;
			case 182: return _v182;
			case 183: return _v183;
			case 184: return _v184;
			case 185: return _v185;
			case 186: return _v186;
			case 187: return _v187;
			case 188: return _v188;
			case 189: return _v189;
			case 190: return _v190;
			case 191: return _v191;
			case 192: return _v192;
			case 193: return _v193;
			case 194: return _v194;
			case 195: return _v195;
			case 196: return _v196;
			case 197: return _v197;
			case 198: return _v198;
			case 199: return _v199;
			case 200: return _v200;
			case 201: return _v201;
			case 202: return _v202;
			case 203: return _v203;
			case 204: return _v204;
			case 205: return _v205;
			case 206: return _v206;
			case 207: return _v207;
			case 208: return _v208;
			case 209: return _v209;
			case 210: return _v210;
			case 211: return _v211;
			case 212: return _v212;
			case 213: return _v213;
			case 214: return _v214;
			case 215: return _v215;
			case 216: return _v216;
			case 217: return _v217;
			case 218: return _v218;
			case 219: return _v219;
			case 220: return _v220;
			case 221: return _v221;
			case 222: return _v222;
			case 223: return _v223;
			case 224: return _v224;
			case 225: return _v225;
			case 226: return _v226;
			case 227: return _v227;
			case 228: return _v228;
			case 229: return _v229;
			case 230: return _v230;
			case 231: return _v231;
			case 232: return _v232;
			case 233: return _v233;
			case 234: return _v234;
			case 235: return _v235;
			case 236: return _v236;
			case 237: return _v237;
			case 238: return _v238;
			case 239: return _v239;
			case 240: return _v240;
			case 241: return _v241;
			case 242: return _v242;
			case 243: return _v243;
			case 244: return _v244;
			case 245: return _v245;
			case 246: return _v246;
			case 247: return _v247;
			case 248: return _v248;
			case 249: return _v249;
			case 250: return _v250;
			case 251: return _v251;
			case 252: return _v252;
			case 253: return _v253;
			case 254: return _v254;
			case 255: return _v255;
			default:
				BoundsError(); return default(T);
			}
		}
		void SetRaw(int index, T value) {
			switch (index) {
			case 0: _v0 = value; return;
			case 1: _v1 = value; return;
			case 2: _v2 = value; return;
			case 3: _v3 = value; return;
			case 4: _v4 = value; return;
			case 5: _v5 = value; return;
			case 6: _v6 = value; return;
			case 7: _v7 = value; return;
			case 8: _v8 = value; return;
			case 9: _v9 = value; return;
			case 10: _v10 = value; return;
			case 11: _v11 = value; return;
			case 12: _v12 = value; return;
			case 13: _v13 = value; return;
			case 14: _v14 = value; return;
			case 15: _v15 = value; return;
			case 16: _v16 = value; return;
			case 17: _v17 = value; return;
			case 18: _v18 = value; return;
			case 19: _v19 = value; return;
			case 20: _v20 = value; return;
			case 21: _v21 = value; return;
			case 22: _v22 = value; return;
			case 23: _v23 = value; return;
			case 24: _v24 = value; return;
			case 25: _v25 = value; return;
			case 26: _v26 = value; return;
			case 27: _v27 = value; return;
			case 28: _v28 = value; return;
			case 29: _v29 = value; return;
			case 30: _v30 = value; return;
			case 31: _v31 = value; return;
			case 32: _v32 = value; return;
			case 33: _v33 = value; return;
			case 34: _v34 = value; return;
			case 35: _v35 = value; return;
			case 36: _v36 = value; return;
			case 37: _v37 = value; return;
			case 38: _v38 = value; return;
			case 39: _v39 = value; return;
			case 40: _v40 = value; return;
			case 41: _v41 = value; return;
			case 42: _v42 = value; return;
			case 43: _v43 = value; return;
			case 44: _v44 = value; return;
			case 45: _v45 = value; return;
			case 46: _v46 = value; return;
			case 47: _v47 = value; return;
			case 48: _v48 = value; return;
			case 49: _v49 = value; return;
			case 50: _v50 = value; return;
			case 51: _v51 = value; return;
			case 52: _v52 = value; return;
			case 53: _v53 = value; return;
			case 54: _v54 = value; return;
			case 55: _v55 = value; return;
			case 56: _v56 = value; return;
			case 57: _v57 = value; return;
			case 58: _v58 = value; return;
			case 59: _v59 = value; return;
			case 60: _v60 = value; return;
			case 61: _v61 = value; return;
			case 62: _v62 = value; return;
			case 63: _v63 = value; return;
			case 64: _v64 = value; return;
			case 65: _v65 = value; return;
			case 66: _v66 = value; return;
			case 67: _v67 = value; return;
			case 68: _v68 = value; return;
			case 69: _v69 = value; return;
			case 70: _v70 = value; return;
			case 71: _v71 = value; return;
			case 72: _v72 = value; return;
			case 73: _v73 = value; return;
			case 74: _v74 = value; return;
			case 75: _v75 = value; return;
			case 76: _v76 = value; return;
			case 77: _v77 = value; return;
			case 78: _v78 = value; return;
			case 79: _v79 = value; return;
			case 80: _v80 = value; return;
			case 81: _v81 = value; return;
			case 82: _v82 = value; return;
			case 83: _v83 = value; return;
			case 84: _v84 = value; return;
			case 85: _v85 = value; return;
			case 86: _v86 = value; return;
			case 87: _v87 = value; return;
			case 88: _v88 = value; return;
			case 89: _v89 = value; return;
			case 90: _v90 = value; return;
			case 91: _v91 = value; return;
			case 92: _v92 = value; return;
			case 93: _v93 = value; return;
			case 94: _v94 = value; return;
			case 95: _v95 = value; return;
			case 96: _v96 = value; return;
			case 97: _v97 = value; return;
			case 98: _v98 = value; return;
			case 99: _v99 = value; return;
			case 100: _v100 = value; return;
			case 101: _v101 = value; return;
			case 102: _v102 = value; return;
			case 103: _v103 = value; return;
			case 104: _v104 = value; return;
			case 105: _v105 = value; return;
			case 106: _v106 = value; return;
			case 107: _v107 = value; return;
			case 108: _v108 = value; return;
			case 109: _v109 = value; return;
			case 110: _v110 = value; return;
			case 111: _v111 = value; return;
			case 112: _v112 = value; return;
			case 113: _v113 = value; return;
			case 114: _v114 = value; return;
			case 115: _v115 = value; return;
			case 116: _v116 = value; return;
			case 117: _v117 = value; return;
			case 118: _v118 = value; return;
			case 119: _v119 = value; return;
			case 120: _v120 = value; return;
			case 121: _v121 = value; return;
			case 122: _v122 = value; return;
			case 123: _v123 = value; return;
			case 124: _v124 = value; return;
			case 125: _v125 = value; return;
			case 126: _v126 = value; return;
			case 127: _v127 = value; return;
			case 128: _v128 = value; return;
			case 129: _v129 = value; return;
			case 130: _v130 = value; return;
			case 131: _v131 = value; return;
			case 132: _v132 = value; return;
			case 133: _v133 = value; return;
			case 134: _v134 = value; return;
			case 135: _v135 = value; return;
			case 136: _v136 = value; return;
			case 137: _v137 = value; return;
			case 138: _v138 = value; return;
			case 139: _v139 = value; return;
			case 140: _v140 = value; return;
			case 141: _v141 = value; return;
			case 142: _v142 = value; return;
			case 143: _v143 = value; return;
			case 144: _v144 = value; return;
			case 145: _v145 = value; return;
			case 146: _v146 = value; return;
			case 147: _v147 = value; return;
			case 148: _v148 = value; return;
			case 149: _v149 = value; return;
			case 150: _v150 = value; return;
			case 151: _v151 = value; return;
			case 152: _v152 = value; return;
			case 153: _v153 = value; return;
			case 154: _v154 = value; return;
			case 155: _v155 = value; return;
			case 156: _v156 = value; return;
			case 157: _v157 = value; return;
			case 158: _v158 = value; return;
			case 159: _v159 = value; return;
			case 160: _v160 = value; return;
			case 161: _v161 = value; return;
			case 162: _v162 = value; return;
			case 163: _v163 = value; return;
			case 164: _v164 = value; return;
			case 165: _v165 = value; return;
			case 166: _v166 = value; return;
			case 167: _v167 = value; return;
			case 168: _v168 = value; return;
			case 169: _v169 = value; return;
			case 170: _v170 = value; return;
			case 171: _v171 = value; return;
			case 172: _v172 = value; return;
			case 173: _v173 = value; return;
			case 174: _v174 = value; return;
			case 175: _v175 = value; return;
			case 176: _v176 = value; return;
			case 177: _v177 = value; return;
			case 178: _v178 = value; return;
			case 179: _v179 = value; return;
			case 180: _v180 = value; return;
			case 181: _v181 = value; return;
			case 182: _v182 = value; return;
			case 183: _v183 = value; return;
			case 184: _v184 = value; return;
			case 185: _v185 = value; return;
			case 186: _v186 = value; return;
			case 187: _v187 = value; return;
			case 188: _v188 = value; return;
			case 189: _v189 = value; return;
			case 190: _v190 = value; return;
			case 191: _v191 = value; return;
			case 192: _v192 = value; return;
			case 193: _v193 = value; return;
			case 194: _v194 = value; return;
			case 195: _v195 = value; return;
			case 196: _v196 = value; return;
			case 197: _v197 = value; return;
			case 198: _v198 = value; return;
			case 199: _v199 = value; return;
			case 200: _v200 = value; return;
			case 201: _v201 = value; return;
			case 202: _v202 = value; return;
			case 203: _v203 = value; return;
			case 204: _v204 = value; return;
			case 205: _v205 = value; return;
			case 206: _v206 = value; return;
			case 207: _v207 = value; return;
			case 208: _v208 = value; return;
			case 209: _v209 = value; return;
			case 210: _v210 = value; return;
			case 211: _v211 = value; return;
			case 212: _v212 = value; return;
			case 213: _v213 = value; return;
			case 214: _v214 = value; return;
			case 215: _v215 = value; return;
			case 216: _v216 = value; return;
			case 217: _v217 = value; return;
			case 218: _v218 = value; return;
			case 219: _v219 = value; return;
			case 220: _v220 = value; return;
			case 221: _v221 = value; return;
			case 222: _v222 = value; return;
			case 223: _v223 = value; return;
			case 224: _v224 = value; return;
			case 225: _v225 = value; return;
			case 226: _v226 = value; return;
			case 227: _v227 = value; return;
			case 228: _v228 = value; return;
			case 229: _v229 = value; return;
			case 230: _v230 = value; return;
			case 231: _v231 = value; return;
			case 232: _v232 = value; return;
			case 233: _v233 = value; return;
			case 234: _v234 = value; return;
			case 235: _v235 = value; return;
			case 236: _v236 = value; return;
			case 237: _v237 = value; return;
			case 238: _v238 = value; return;
			case 239: _v239 = value; return;
			case 240: _v240 = value; return;
			case 241: _v241 = value; return;
			case 242: _v242 = value; return;
			case 243: _v243 = value; return;
			case 244: _v244 = value; return;
			case 245: _v245 = value; return;
			case 246: _v246 = value; return;
			case 247: _v247 = value; return;
			case 248: _v248 = value; return;
			case 249: _v249 = value; return;
			case 250: _v250 = value; return;
			case 251: _v251 = value; return;
			case 252: _v252 = value; return;
			case 253: _v253 = value; return;
			case 254: _v254 = value; return;
			case 255: _v255 = value; return;
			default:
				BoundsError(); return;
			}
		}

		public T this[int index] {
			get {
				CheckBounds(index);
				return GetRaw(index);
			}
			set {
				CheckBounds(index);
				SetRaw(index, value);
			}
		}

		public int Count {
			get {
				return _count;
			}
		}
		public bool IsReadOnly {
			get {
				return false;
			}
		}
		public void Add(T item)
		{
			if (_count >= 256) BoundsError();
			var index = _count;
			SetRaw(index, item);
			_count += 1;
		}
		public void Clear()
		{
			_count = 0;
		}
		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}
		public int IndexOf(T item)
		{
			var e = EqualityComparer<T>.Default;
			for (var i=0; i<_count; i++) {
				if (e.Equals(GetRaw(i), item))
					return i;
			}
			return -1;
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			for (var i=0; i<_count;i++) {
				array[arrayIndex + i] = GetRaw(i);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (var i=0; i<_count;i++) {
				yield return GetRaw(i);
			}
		}

		public void Insert(int index, T item)
		{
			if (_count == 256) BoundsError();
			_count += 1;
			CheckBounds(index);
			for (var i = _count-1; i > index; i--) {
				SetRaw(i, GetRaw(i-1));
			}
			SetRaw(index, item);
		}
		public bool Remove(T item) {
			var idx = IndexOf(item);
			if (idx == -1) return false;
			RemoveAt(idx);
			return true;
		}
		public void RemoveAt(int index)
		{
			CheckBounds(index);
			for (var i = index; i < _count; i++) {
				SetRaw(i, GetRaw(i+1));
			}
			_count -= 1;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

}
