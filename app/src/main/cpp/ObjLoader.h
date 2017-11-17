//
// Created by kanga on 17.11.2017.
//

#ifndef ARDOG_OBJLOADER_H
#define ARDOG_OBJLOADER_H

#include <jni.h>
#include <unistd.h>
#include <tango-gl/util.h>
#include <android/asset_manager.h>

class ObjLoader {
private:
    bool ready;

public:
    ObjLoader( ){
        this->ready = false;
    }
    ObjLoader( struct android_app* state ){
        JNIEnv* env = state->activity->env;
        JavaVM* vm = state->activity->vm;
        vm->AttachCurrentThread(&env, NULL);

        jclass activityClass = env->GetObjectClass( state->activity->clazz );

        // Get path to cache dir (/data/data/org.wikibooks.OpenGL/cache)
        jmethodID getCacheDir = env->GetMethodID( activityClass, "getCacheDir", "()Ljava/io/File;" );
        jobject file = env->CallObjectMethod( state->activity->clazz, getCacheDir );
        jclass fileClass = env->FindClass( "java/io/File" );
        jmethodID getAbsolutePath = env->GetMethodID( fileClass, "getAbsolutePath", "()Ljava/lang/String;" );
        jstring jpath = (jstring)env->CallObjectMethod( file, getAbsolutePath );
        const char* app_dir = env->GetStringUTFChars( jpath, NULL );

        // chdir in the application cache directory
        LOGI("app_dir: %s", app_dir);
        chdir(app_dir);
        env->ReleaseStringUTFChars(jpath, app_dir);

        jobject assetManager = state->activity->assetManager;
        AAssetManager* mgr = AAssetManager_fromJava(env, assetManager);

        this->ready = true;
    }

    static void import( const char* filename,  ){
        if( !this->ready )
            return;

        AAssetDir* assetDir = AAssetManager_openDir(mgr, "");
        const char* filename = (const char*)NULL;
        while ((filename = AAssetDir_getNextFileName(assetDir)) != NULL) {
            AAsset* asset = AAssetManager_open(mgr, filename, AASSET_MODE_STREAMING);
            char buf[BUFSIZ];
            int nb_read = 0;
            FILE* out = fopen(filename, "w");
            while ((nb_read = AAsset_read(asset, buf, BUFSIZ)) > 0)
                fwrite(buf, nb_read, 1, out);
            fclose(out);
            AAsset_close(asset);
        }
        AAssetDir_close(assetDir);
    }
};


#endif //ARDOG_OBJLOADER_H
