//
// Created by kanga on 18.11.2017.
//

#ifndef ARDOG_SCENE_H
#define ARDOG_SCENE_H

#include <jni.h>
#include <memory>
#include <math.h>

#include <android/asset_manager.h>

#include <tango_client_api.h>  // NOLINT
#include <tango-gl/camera.h>
#include <tango-gl/color.h>
#include <tango-gl/transform.h>
#include <tango-gl/util.h>
#include <tango-gl/video_overlay.h>
#include <tango-gl/texture.h>
#include <tango-gl/meshes.h>
#include <tango-gl/shaders.h>
#include <tango-gl/tango-gl.h>

namespace ARDog {
    class Scene {
    public:
        Scene();
        ~Scene();

        void InitGLContent(AAssetManager* aasset_manager );
        void DeleteResources();
        void SetupViewport( int w, int h );
        void Clear();
        void Render( const glm::mat4& cur_pose_transformation );

        GLuint GetVideoOverlayTextureId(){ return video_overlay_->GetTextureId(); }
        float GetCameraImagePlaneRation(){ return camera_image_plane_ratio_; }
        void SetCameraImagePlaneRatio( float ratio ){
            camera_image_plane_ratio_ = ratio;
        }
        float GetImagePlaneDistance(){ return image_plane_distance_; }
        void SetImagePlaneDistance( float distance ) { image_plane_distance_ = distance; }
        void SetProjectionMatrix(const glm::mat4& projection_matrix);
        void SetVideoOverlayRotation(int display_rotation);

    private:
        tango_gl::VideoOverlay* video_overlay_;
        tango_gl::Camera* camera_;
        float camera_image_plane_ratio_;
        float image_plane_distance_;
        glm::mat4 ar_camera_projection_matrix_;

        bool is_content_initialized_ = false;
        int viewport_width_;
        int viewport_height_;
    };
}

#endif //ARDOG_SCENE_H
