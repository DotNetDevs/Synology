using Microsoft.Extensions.DependencyInjection;
using Synology.Api;
using Synology.Api.Auth;
using Synology.AudioStation;
using Synology.DownloadStation;
using Synology.DownloadStation.Schedule;
using Synology.DownloadStation2;
using Synology.FileStation;
using Synology.FileStation.CheckPermission;
using Synology.FileStation.CopyMove;
using Synology.FileStation.DirSize;
using Synology.FileStation.Favorite;
using Synology.FileStation.FileShare;
using Synology.FileStation.List;
using Synology.FileStation.MD5;
using Synology.FileStation.Rename;
using Synology.FileStation.Search;
using Synology.FileStation.Thumb;
using Synology.FileStation.Upload;
using Synology.FileStation.VirtualFolder;
using Synology.Interfaces;
using Synology.SurveillanceStation;
using Synology.VideoStation;

namespace Synology.Classes
{
    class SynologyBuilder : ISynologyBuilder
    {
        public SynologyBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
        
        public ISynologyBuilder AddApi()
        {
            Services.AddTransient<IApi, Api.Api>();
            Services.AddTransient<Api.Info.IInfoRequest, Api.Info.InfoRequest>();
            Services.AddTransient<IAuthRequest, AuthRequest>();

            return this;
        }

        public ISynologyBuilder AddAudioStation()
        {
            Services.AddTransient<IAudioStationApi, AudioStationApi>();

            return this;
        }

        public ISynologyBuilder AddDownloadStation()
        {
            Services.AddTransient<IDownloadStationApi, DownloadStationApi>();
            Services.AddTransient<DownloadStation.Info.IInfoRequest, DownloadStation.Info.InfoRequest>();
            Services.AddTransient<IScheduleRequest, ScheduleRequest>();
            Services.AddTransient<DownloadStation.Task.ITaskRequest, DownloadStation.Task.TaskRequest>();

            return this;
        }

        public ISynologyBuilder AddDownloadStation2()
        {
            Services.AddTransient<IDownloadStation2Api, DownloadStation2Api>();
            Services.AddTransient<DownloadStation2.Task.ITaskRequest, DownloadStation2.Task.TaskRequest>();

            return this;
        }

        public ISynologyBuilder AddFileStation()
        {
            Services.AddTransient<IFileStationApi, FileStationApi>();
            Services.AddTransient<FileStation.Info.IInfoRequest, FileStation.Info.InfoRequest>();
            Services.AddTransient<ICheckPermissionRequest, CheckPermissionRequest>();
            Services.AddTransient<ICopyMoveRequest, CopyMoveRequest>();
            Services.AddTransient<IDirSizeRequest, DirSizeRequest>();
            Services.AddTransient<IFavoriteRequest, FavoriteRequest>();
            Services.AddTransient<IFileShareRequest, FileShareRequest>();
            Services.AddTransient<IListRequest, ListRequest>();
            Services.AddTransient<IMD5Request, MD5Request>();
            Services.AddTransient<IRenameRequest, RenameRequest>();
            Services.AddTransient<ISearchRequest, SearchRequest>();
            Services.AddTransient<IThumbRequest, ThumbRequest>();
            Services.AddTransient<IUploadRequest, UploadRequest>();
            Services.AddTransient<IVirtualFolderRequest, VirtualFolderRequest>();

            return this;
        }

        public ISynologyBuilder AddSurveillanceStation()
        {
            Services.AddTransient<ISurveillanceStationApi, SurveillanceStationApi>();
            Services.AddTransient<SurveillanceStation.Info.IInfoRequest, SurveillanceStation.Info.InfoRequest>();

            return this;
        }

        public ISynologyBuilder AddVideoStation()
        {
            Services.AddTransient<IVideoStationApi, VideoStationApi>();

            return this;
        }
    }
}
