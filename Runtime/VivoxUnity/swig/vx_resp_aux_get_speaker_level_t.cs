//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vx_resp_aux_get_speaker_level_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vx_resp_aux_get_speaker_level_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vx_resp_aux_get_speaker_level_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vx_resp_aux_get_speaker_level_t() {
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
          VivoxCoreInstancePINVOKE.delete_vx_resp_aux_get_speaker_level_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public vx_resp_base_t base_ {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_aux_get_speaker_level_t_base__set(swigCPtr, vx_resp_base_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_resp_aux_get_speaker_level_t_base__get(swigCPtr);
      vx_resp_base_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new vx_resp_base_t(cPtr, false);
      return ret;
    } 
  }

  public int level {
    set {
      VivoxCoreInstancePINVOKE.vx_resp_aux_get_speaker_level_t_level_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_resp_aux_get_speaker_level_t_level_get(swigCPtr);
      return ret;
    } 
  }

  public vx_resp_aux_get_speaker_level_t() : this(VivoxCoreInstancePINVOKE.new_vx_resp_aux_get_speaker_level_t(), true) {
  }

}
