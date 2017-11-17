//
// Created by kanga on 17.11.2017.
//

#include <sstream>
#include <string>

#include <tango-gl/conversions.h>
#include <tango_support.h>

#include "app.h"

namespace ARDog {
    void APP::onCreate(JNIEnv *env, jobject caller_activity, int display_rotation) {

    }

    void APP::onTangoServiceConnected(JNIEnv *env, jobject jBinder) {
        std::lock_guard<std::mutex> lock(tango_event_mutex_);
        tango_event_data_.UpdateTangoEvent(event);
    }

    void APP::onTangoEventAvailable(const TangoEvent *event) {

    }

    void APP::onSurfaceCreated(AAssetManager *aasset_manager) {

    }

    void APP::onSurfaceChanged(int width, int height) {

    }

    void APP::onDrawFrame() {

    }

    void APP::onPause() {

    }

    void APP::onDestroy() {

    }
}


