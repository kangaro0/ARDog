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

#include "tango_event_data.h"
#include "scene.h"

#ifndef ARDOG_APP_H
#define ARDOG_APP_H

namespace ARDog {

    class APP {
    private:
        // TANGO
        TangoConfig tango_config_;
        TangoCameraIntrinsics color_camera_intrinsics_;
        std::string tango_core_version_string_;
        TangoEventData tango_event_data_;
        std::mutex tango_event_mutex_;

        // Transform
        double cur_timestamp_;
        double prev_timestamp_;
        size_t transform_counter_;

        std::mutex transform_mutex_;

        std::string transform_string_;
        glm::mat4 cur_start_service_T_camera_;
        glm::mat4 prev_start_service_T_camera_;

        // Scene
        Scene main_scene_;

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

        // Render Helper Functions
        void RequestRender();
        void UpdateTransform(const double transform[16], double timestamp);
        void FormatTransformString();
        void UpdateViewportAndProjectionMatrix();
        // Tango Helper Functions
        void TangoSetupConfig();
        void TangoConnectCallbacks();
        void TangoConnect();
        void TangoDisconnect();
        // Free memory of non-OpenGL resources
        void DeleteResources();

    public:
        // Lifecycle Hooks
        void onCreate( JNIEnv* env, jobject caller_activity, int display_rotation );
        void onTangoServiceConnected( JNIEnv* env, jobject jBinder );
        void onTangoEventAvailable(const TangoEvent* event);
        void onTextureAvailable(TangoCameraId id);
        void onSurfaceCreated(AAssetManager* aasset_manager);
        void onSurfaceChanged(int width, int height);
        void onDrawFrame();
        void onPause();
        void onDestroy();
        void onDeviceRotationChanged(int display_rotation);

        // Sonstiges
        std::string GetTransformString();
        std::string GetEventString();
        std::string GetVersionString();

        // JavaVM
        void SetJavaVM(JavaVM* java_vm) { java_vm_ = java_vm; }

    };
}

#endif //ARDOG_APP_H
