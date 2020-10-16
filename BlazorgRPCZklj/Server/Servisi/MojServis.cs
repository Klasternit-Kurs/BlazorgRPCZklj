using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using grpcTest;

namespace BlazorgRPCZklj.Server.Servisi
{
	public class MojServis : ProbniServis.ProbniServisBase
	{
		public override Task<ProbnaPoruka> ProbniPoziv(ProbnaPoruka r, ServerCallContext context)
		{
			return Task.FromResult(new ProbnaPoruka { Nesto = r.Nesto.ToUpper(), NekiBroj = r.NekiBroj * 2 });
		}

		public override Task<AdresaPoruka> Adresa(ProbnaPoruka request, ServerCallContext context)
		{
			return base.Adresa(request, context);
		}
	}
}
