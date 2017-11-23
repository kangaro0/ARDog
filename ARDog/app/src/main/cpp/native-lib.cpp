#include <jni.h>

#define GLM_FORCE_RADIANS

#include <android/asset_manager.h>
#include <android/asset_manager_jni.h>

#include <jni.h>
#include <app.h>

static ARDog::APP app;

#ifdef __cplusplus
extern "C" {
#endif
jint JNI_OnLoad(JavaVM* vm, void*) {
    // We need to store a reference to the Java VM so that we can call into the
    // Java layer to trigger rendering.
    app.SetJavaVM(vm);
    return JNI_VERSION_1_6;
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onCreate(
        JNIEnv* env, jobject, jobject activity, int display_orientation) {
    app.onCreate(env, activity, display_orientation);
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onTangoServiceConnected(
        JNIEnv* env, jobject, jobject iBinder) {
    app.onTangoServiceConnected(env, iBinder);
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onPause(
        JNIEnv*, jobject) {
    app.onPause();
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onDestroy(
        JNIEnv*, jobject) {
    app.onDestroy();
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onGlSurfaceCreated(
        JNIEnv* env, jobject, jobject j_asset_manager) {
    AAssetManager* aasset_manager = AAssetManager_fromJava(env, j_asset_manager);
    app.onSurfaceCreated(aasset_manager);
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onGlSurfaceChanged(
        JNIEnv*, jobject, jint width, jint height) {
    app.onSurfaceChanged(width, height);
}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onGlSurfaceDrawFrame(
        JNIEnv*, jobject) {
    app.onDrawFrame();}

JNIEXPORT void JNICALL
Java_com_projecttango_examples_cpp_augmentedreality_TangoJNINative_onConfigurationChanged(
        JNIEnv*, jobject, int display_orientation) {
    app.onDeviceRotationChanged(display_orientation);
}

#ifdef __cplusplus
}
#endif