﻿namespace LOCMI.Certificates;

using LOCMI.Controllers;

public sealed class CertificateDemonstrationDTO
{
    private List<Certificate> _certificates;

    private PromptController _promptController;

    public CertificateDemonstrationDTO()
    {
        _certificates = new List<Certificate>();
    }

    public void Apply()
    {
        foreach (Certificate certificate in _certificates)
        {
            certificate.Certify();
        }
    }

    public IEnumerable<Certificate> GetCertificates()
    {
        return _certificates;
    }

    public void SetCertificates(List<Certificate> certificates)
    {
        _certificates = certificates;
    }
}