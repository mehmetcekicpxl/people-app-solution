using ExternalPeopleApp.Mvc.UI.ViewModels;

namespace ExternalPeopleApp.Mvc.UI.Services
{
    public class DepartmentApiService
    {
        private readonly HttpClient _httpClient;
        public DepartmentApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<DepartmentViewModel>> GetDepartmentsAsync()
        {
            var response = await _httpClient.GetAsync("api/department");

            if (!response.IsSuccessStatusCode)
                return Enumerable.Empty<DepartmentViewModel>();

            var departments = await response.Content
                .ReadFromJsonAsync<IEnumerable<DepartmentViewModel>>();

            return departments ?? Enumerable.Empty<DepartmentViewModel>();
        }
    }
}
