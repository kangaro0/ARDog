using System;
using System.Diagnostics;
using Urho;
using Urho.Gui;
using Urho.Resources;

namespace UrhoSharpGoogleTango.Scripts
{
    public class DemoScene : Application
    {
        private ResourceCache cache;

        private UrhoConsole console;
        private DebugHud debugHud;
        private Sprite logoSprite;
        /**/
        private Scene scene;
        private UI ui;
        private Node _pointCloudNode;
        private StaticModel _pointCloudModel;

        public DemoScene(ApplicationOptions options = null) : base(options)
        {
        }

        protected Node CameraNode { get; set; }
        protected MonoDebugHud MonoDebugHud { get; set; }


        /// <summary>
        ///     Joystick XML layout for mobile platforms
        /// </summary>
        protected virtual string JoystickLayoutPatch { get; set; } = "";

        public StaticModel PointCloudModel { get { return _pointCloudModel; } }

        public Vector3[] PointCouldPoints;
        private bool _pointCouldIsInvalid;

        protected override void Start()
        {
            base.Start();
            CreateScene();

            Input.Enabled = true;
            Input.SubscribeToTouchBegin(OnTouch);
            MonoDebugHud = new MonoDebugHud(this);
            MonoDebugHud.Show();

            CreateConsoleAndDebugHud();
            Graphics.FlushGPU = true;

            SetupViewport();
        }

        private void OnTouch(TouchBeginEventArgs obj)
        {
            _refreshCould = true;
        }


        private void SetupViewport()
        {
            var graphics = Graphics;
            var renderer = Renderer;
            var cache = ResourceCache;

            var viewport = new Viewport(Context, scene, CameraNode.GetComponent<Camera>(), null);

            renderer.SetViewport(0, viewport);
        }

        protected override void OnUpdate(float timeStep)
        {
            UpdatePointClould();
            base.OnUpdate(timeStep);

        }

        private bool _refreshCould= true;

        private void UpdatePointClould()
        {
            if (!_pointCouldIsInvalid)
                return;
            if (!_refreshCould)
                return;
            _pointCouldIsInvalid = false;
            _refreshCould = false;

            var m = PointCloudModel;
            if (m == null)
                return;
            var g = m.GetLodGeometry(0, 0);
            if (g == null)
                return;
            var vb = g.GetVertexBuffer(0);
            if (vb == null)
                return;
            var vertexRawData = vb.Lock(0, vb.VertexCount, false);

            if (vertexRawData != IntPtr.Zero)
            {
                var cameraW = CameraNode.WorldTransform;
                var depthToWorld = cameraW;//.Inverse();
                var depthToWorld4 = new Matrix4(depthToWorld.m00, depthToWorld.m01, depthToWorld.m02, depthToWorld.m03,
                    depthToWorld.m10, depthToWorld.m11, depthToWorld.m12, depthToWorld.m13,
                    depthToWorld.m20, depthToWorld.m21, depthToWorld.m22, depthToWorld.m23,
                    0, 0, 0, 1);
                depthToWorld4.Transpose();

                uint numVertices = vb.VertexCount;
                uint vertexSize = vb.VertexSize;
                int j;
                for (j = 0; j < numVertices; ++j)
                {
                    unsafe
                    {
                        //TODO: avoid unsafe
                        Vector3* v0 = (Vector3*)IntPtr.Add(vertexRawData, j * (int)vertexSize);
                        var v = PointCouldPoints[j];

                        var w = Vector3.Transform(v, depthToWorld4);
                        var x = w.X / w.W;
                        var y = w.Y / w.W;
                        var z = w.Z / w.W;

                        v0->X = x;
                        v0->Y = y;
                        v0->Z = z;
                    }
                }

            }
            vb.Unlock();

        }

        private void CreateScene()
        {
            var haveShadow = false;

            var cache = ResourceCache;

            scene = new Scene(Context);
            scene.LoadXmlFromCache(ResourceCache, "Scenes/TangoScene.xml");

            //scene.CreateComponent<Octree>();
            // Create octree, use default volume (-1000, -1000, -1000) to (1000, 1000, 1000)
            //scene.CreateComponent<Octree>();

            // Create a Zone component for ambient lighting & fog control
            //var zoneNode = scene.CreateChild("Zone");
            //var zone = zoneNode.CreateComponent<Zone>();
            //zone.SetBoundingBox(new BoundingBox(-1000.0f, 1000.0f));
            //zone.AmbientColor = new Color(0.15f, 0.15f, 0.15f);
            //zone.FogColor = new Color(1.0f, 1.0f, 1.0f);
            //zone.FogStart = 500.0f;
            //zone.FogEnd = 750.0f;


            // Create skybox. The Skybox component is used like StaticModel, but it will be always located at the camera, giving the
            // illusion of the box planes being far away. Use just the ordinary Box model and a suitable material, whose shader will
            // generate the necessary 3D texture coordinates for cube mapping
            //var skyNode = scene.CreateChild("Sky");
            //skyNode.SetScale(500.0f); // The scale actually does not matter
            //var skybox = skyNode.CreateComponent<Skybox>();
            ////skybox.Model = cache.GetModel("Models/sky01.mdl");
            ////skybox.SetMaterial(cache.GetMaterial("Materials/Sky.xml"));
            //skybox.Model = cache.GetModel("Models/Box.mdl");
            //skybox.SetMaterial(cache.GetMaterial("Materials/Skybox.xml"));


            // Create the camera. Limit far clip distance to match the fog
            CameraNode = new Node();
            var camera = CameraNode.CreateComponent<Camera>();
            camera.FarClip = 750.0f;
            // Set an initial position for the camera scene node above the plane
            //SlideCamera(0);

            _pointCloudNode = scene.CreateChild("PointCloud");
            _pointCloudModel = _pointCloudNode.CreateComponent<StaticModel>();
            _pointCloudModel.Model = cache.GetModel("Models/PointCloud.mdl");
            _pointCloudModel.SetMaterial(cache.GetMaterial("Materials/PointMaterial.xml"));
            
            PointCouldPoints = new Vector3[_pointCloudModel.GetLodGeometry(0, 0).VertexBuffers[0].VertexCount];

            SetCameraPositoin(new Vector3(0, 0, 0));
        }

        public void SetCameraPositoin(Vector3 vector3)
        {
            if (CameraNode != null)
            {
                CameraNode.Position = vector3 + new Vector3(0, 1, 0);
            }
        }

        public void SetCameraRotation(Quaternion quaternion)
        {
            if (CameraNode != null)
                CameraNode.Rotation = quaternion;
        }


        private void CreateConsoleAndDebugHud()
        {
            //var xml = cache.GetXmlFile("UI/DefaultStyle.xml");
            //console = Engine.CreateConsole();
            //console.DefaultStyle = xml;
            //console.Background.Opacity = 0.8f;

            debugHud = Engine.CreateDebugHud();
            //debugHud.DefaultStyle = xml;
        }

        public void IvalidatePointCloud()
        {
            _pointCouldIsInvalid = true;
        }
    }
}