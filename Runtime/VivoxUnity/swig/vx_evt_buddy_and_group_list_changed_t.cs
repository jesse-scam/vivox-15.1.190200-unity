//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vx_evt_buddy_and_group_list_changed_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vx_evt_buddy_and_group_list_changed_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vx_evt_buddy_and_group_list_changed_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vx_evt_buddy_and_group_list_changed_t() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VivoxCoreInstancePINVOKE.delete_vx_evt_buddy_and_group_list_changed_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public vx_evt_base_t base_ {
    set {
      VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_base__set(swigCPtr, vx_evt_base_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_base__get(swigCPtr);
      vx_evt_base_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new vx_evt_base_t(cPtr, false);
      return ret;
    } 
  }

  public string account_handle {
    set {
      VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_account_handle_set(swigCPtr, value);
    } 
    get {
      string ret = VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_account_handle_get(swigCPtr);
      return ret;
    } 
  }

  public int buddy_count {
    set {
      VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_buddy_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_buddy_count_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_vx_buddy buddies {
    set {
      VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_buddies_set(swigCPtr, SWIGTYPE_p_p_vx_buddy.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_buddies_get(swigCPtr);
      SWIGTYPE_p_p_vx_buddy ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_vx_buddy(cPtr, false);
      return ret;
    } 
  }

  public int group_count {
    set {
      VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_group_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_group_count_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_vx_group groups {
    set {
      VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_groups_set(swigCPtr, SWIGTYPE_p_p_vx_group.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_evt_buddy_and_group_list_changed_t_groups_get(swigCPtr);
      SWIGTYPE_p_p_vx_group ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_vx_group(cPtr, false);
      return ret;
    } 
  }

  public vx_evt_buddy_and_group_list_changed_t() : this(VivoxCoreInstancePINVOKE.new_vx_evt_buddy_and_group_list_changed_t(), true) {
  }

}
