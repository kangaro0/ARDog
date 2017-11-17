//
// Created by kanga on 17.11.2017.
//

#include <atomic>
#include <jni.h>
#include <memory>
#include <string>
#include <mutex>

#include <android/asset_manager.h>
#include <android/asset_manager_jni.h>

#include <tango_client_api.h>  // NOLINT
#include <tango-gl/util.h>

#ifndef ARDOG_APP_H
#define ARDOG_APP_H

namespace ARDog {

    class APP {
    private:
        // MUTEX, we have at least 2 threads ( render, etc.. )
        std::mutex transform_mutex_;
        std::mutex tango_event_mutex_;

        // TANGO
        TangoConfig tango_config_;
        TangoCameraIntrinsics color_camera_intrinsics_;
        TangoEventData tango_event_data_;
        std::string tango_core_version_string_;

        // JAVA
        JavaVM* java_vm_;
        jobject calling_activity_obj_;
        jmethodID on_demand_render_;

        std::atomic<bool> is_service_connected_;
        std::atomic<bool> is_gl_initialized_;
        std::atomic<bool> is_video_overlay_rotation_set_;

        int viewport_width_;
        int viewport_height_;

        int display_rotation_;

    public:

        void onCreate( JNIEnv* env, jobject caller_activity, int display_rotation );
        void onTangoServiceConnected( JNIEnv* env, jobject jBinder );
        void onTangoEventAvailable(const TangoEvent* event);
        void onSurfaceCreated(AAssetManager* aasset_manager);
        void onSurfaceChanged(int width, int height);
        void onDrawFrame();
        void onPause();
        void onDestroy();
    };
}

#endif //ARDOG_APP_H
