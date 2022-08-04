using ApplicationCoopCommon;
using ApplicationCoopCommon.Interfaces;
using ApplicationCoopDal;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopBL
{
    public class ApplicationManager
    {
        private readonly IApplicationRepository applicationRepository;
        private readonly ILogger logger;

        public ApplicationManager(IApplicationRepository applicationRepository, ILogger logger)
        {
            this.applicationRepository = applicationRepository;
            this.logger = logger;
        }

        public void Add(Application application)
        {
            this.applicationRepository.Add(application);
        }

        public Application Get(string id)
        {
            this.logger.Log($"applicationManager get id:{id}");
            var application = this.applicationRepository.Get(id);

            if (application != null)
            {
                this.logger.Log($"applicationManager get id:{application.ID} name:{application.Name}");
            }

            return application;
        }
        public Application Delete(string id)
        {
            this.logger.Log($"applicationManager get id:{id}");
            var application = this.applicationRepository.Get(id);

            if (application != null)
            {
                this.applicationRepository.Delete(id);
            }

            return application;
        }
        public Application Update(string id, Application application)
        {
            this.logger.Log($"applicationManager get id:{id}");
            var application = this.applicationRepository.Get(id);

            if (application != null)
            {
                this.applicationRepository.Update(id, application);
            }

            return application;
        }
    }
}