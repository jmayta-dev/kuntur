using MW.KUNTUR.Bio.Domain.Entities;

namespace MW.KUNTUR.Bio.Domain.Interfaces;

public interface IBioRepository : IDisposable
{
    Company GetCompanyById(int CompanyId, CancellationToken cancellationToken = default);
    Company GetCompanyByJobId(int JobId, CancellationToken cancellationToken = default);
    int CreateCompany(Company company, CancellationToken cancellationToken = default);
    int CreateJob(Job job, CancellationToken cancellationToken = default);
    Task<int> CreatePerson(Person person, CancellationToken cancellationToken = default);
    int CreateProject(Project project, CancellationToken cancellationToken = default);
    int CreateSocialNetwork(SocialNetwork socialNetwork, CancellationToken cancellationToken = default);
    int CreateTechnology(Technology technology, CancellationToken cancellationToken = default);
    IReadOnlyCollection<Job> GetJobsByPersonId(int PersonId, CancellationToken cancellationToken = default);
    IReadOnlyCollection<Project> GetProjectsByPersonId(int PersonId, CancellationToken cancellationToken = default);
    IReadOnlyCollection<SocialNetwork> GetAllSocialNetworks(CancellationToken cancellationToken = default);
    IReadOnlyCollection<SocialNetwork> GetSocialNetworksByPersonId(int PersonId, CancellationToken cancellationToken = default);
    IReadOnlyCollection<Technology> GetTechnologiesByProjectId(int ProjectId, CancellationToken cancellationToken = default);
    Job GetJobById(int JobId, CancellationToken cancellationToken = default);
    Person GetPersonAsync(int PersonId, CancellationToken cancellationToken = default);
    Project GetProjectById(int ProjectId, CancellationToken cancellationToken = default);
    SocialNetwork GetSocialNetworkById(int SocialNetworkId, CancellationToken cancellationToken = default);
    Technology GetTechnologyById(int TechnologyId, CancellationToken cancellationToken = default);
}