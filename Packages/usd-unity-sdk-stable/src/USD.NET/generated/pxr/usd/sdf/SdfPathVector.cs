//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class SdfPathVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<SdfPath>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfPathVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfPathVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfPathVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfPathVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfPathVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (SdfPath element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public SdfPath this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(SdfPath[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(SdfPath[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, SdfPath[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<SdfPath> global::System.Collections.Generic.IEnumerable<SdfPath>.GetEnumerator() {
    return new SdfPathVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new SdfPathVectorEnumerator(this);
  }

  public SdfPathVectorEnumerator GetEnumerator() {
    return new SdfPathVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class SdfPathVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<SdfPath>
  {
    private SdfPathVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public SdfPathVectorEnumerator(SdfPathVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public SdfPath Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (SdfPath)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    UsdCsPINVOKE.SdfPathVector_Clear(swigCPtr);
  }

  public void Add(SdfPath x) {
    UsdCsPINVOKE.SdfPathVector_Add(swigCPtr, SdfPath.getCPtr(x));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = UsdCsPINVOKE.SdfPathVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = UsdCsPINVOKE.SdfPathVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    UsdCsPINVOKE.SdfPathVector_reserve(swigCPtr, n);
  }

  public SdfPathVector() : this(UsdCsPINVOKE.new_SdfPathVector__SWIG_0(), true) {
  }

  public SdfPathVector(SdfPathVector other) : this(UsdCsPINVOKE.new_SdfPathVector__SWIG_1(SdfPathVector.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPathVector(int capacity) : this(UsdCsPINVOKE.new_SdfPathVector__SWIG_2(capacity), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private SdfPath getitemcopy(int index) {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.SdfPathVector_getitemcopy(swigCPtr, index), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private SdfPath getitem(int index) {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.SdfPathVector_getitem(swigCPtr, index), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, SdfPath val) {
    UsdCsPINVOKE.SdfPathVector_setitem(swigCPtr, index, SdfPath.getCPtr(val));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(SdfPathVector values) {
    UsdCsPINVOKE.SdfPathVector_AddRange(swigCPtr, SdfPathVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPathVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdfPathVector_GetRange(swigCPtr, index, count);
    SdfPathVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPathVector(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, SdfPath x) {
    UsdCsPINVOKE.SdfPathVector_Insert(swigCPtr, index, SdfPath.getCPtr(x));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, SdfPathVector values) {
    UsdCsPINVOKE.SdfPathVector_InsertRange(swigCPtr, index, SdfPathVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    UsdCsPINVOKE.SdfPathVector_RemoveAt(swigCPtr, index);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    UsdCsPINVOKE.SdfPathVector_RemoveRange(swigCPtr, index, count);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SdfPathVector Repeat(SdfPath value, int count) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdfPathVector_Repeat(SdfPath.getCPtr(value), count);
    SdfPathVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPathVector(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    UsdCsPINVOKE.SdfPathVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    UsdCsPINVOKE.SdfPathVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, SdfPathVector values) {
    UsdCsPINVOKE.SdfPathVector_SetRange(swigCPtr, index, SdfPathVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
