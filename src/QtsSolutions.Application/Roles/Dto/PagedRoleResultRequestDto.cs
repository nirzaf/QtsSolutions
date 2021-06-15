using Abp.Application.Services.Dto;

namespace QtsSolutions.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

