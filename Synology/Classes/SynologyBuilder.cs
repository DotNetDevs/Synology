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
	internal class SynologyBuilder : ISynologyBuilder
    {
        public SynologyBuilder(IServiceCollection services)
        {
            Services = services;
        }

        private IServiceCollection Services { get; }
        
        public ISynologyBuilder AddApi()
        {
            Services.AddApi<IApi, Api.Api>();

            Services.AddRequest<Api.Info.IInfoRequest, Api.Info.InfoRequest>();
            Services.AddRequest<IAuthRequest, AuthRequest>();

            return this;
        }

        public ISynologyBuilder AddAudioStation()
        {
            Services.AddApi<IAudioStationApi, AudioStationApi>();

            return this;
        }

        public ISynologyBuilder AddDownloadStation()
        {
            Services.AddApi<IDownloadStationApi, DownloadStationApi>();

            Services.AddRequest<DownloadStation.Info.IInfoRequest, DownloadStation.Info.InfoRequest>();
            Services.AddRequest<IScheduleRequest, ScheduleRequest>();
            Services.AddRequest<DownloadStation.Task.ITaskRequest, DownloadStation.Task.TaskRequest>();

            return this;
        }

        public ISynologyBuilder AddDownloadStation2()
        {
            Services.AddApi<IDownloadStation2Api, DownloadStation2Api>();

            Services.AddRequest<DownloadStation2.Task.ITaskRequest, DownloadStation2.Task.TaskRequest>();

            return this;
        }

        public ISynologyBuilder AddFileStation()
        {
            Services.AddApi<IFileStationApi, FileStationApi>();

            Services.AddRequest<FileStation.Info.IInfoRequest, FileStation.Info.InfoRequest>();
            Services.AddRequest<ICheckPermissionRequest, CheckPermissionRequest>();
            Services.AddRequest<ICopyMoveRequest, CopyMoveRequest>();
            Services.AddRequest<IDirSizeRequest, DirSizeRequest>();
            Services.AddRequest<IFavoriteRequest, FavoriteRequest>();
            Services.AddRequest<IFileShareRequest, FileShareRequest>();
            Services.AddRequest<IListRequest, ListRequest>();
            Services.AddRequest<IMD5Request, MD5Request>();
            Services.AddRequest<IRenameRequest, RenameRequest>();
            Services.AddRequest<ISearchRequest, SearchRequest>();
            Services.AddRequest<IThumbRequest, ThumbRequest>();
            Services.AddRequest<IUploadRequest, UploadRequest>();
            Services.AddRequest<IVirtualFolderRequest, VirtualFolderRequest>();

            return this;
        }

        public ISynologyBuilder AddSurveillanceStation()
        {
            Services.AddApi<ISurveillanceStationApi, SurveillanceStationApi>();

            Services.AddRequest<SurveillanceStation.Info.IInfoRequest, SurveillanceStation.Info.InfoRequest>();

            return this;
        }

        public ISynologyBuilder AddVideoStation()
        {
            Services.AddApi<IVideoStationApi, VideoStationApi>();

            return this;
        }
    }
}
