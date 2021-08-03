using ProvaEdesoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaEdesoft
{
    public class crud
    {
        Form1 frm1 = new Form1();
        ModelDonoCao mdc = new ModelDonoCao();

        public ModelDonoCao AcaoOperacao(Operacao.Acao tipoenum, string nomeDono, string Nomecao, string RacaCao)
        {
            try
            {
                Operacao.Acao _valor = tipoenum;

                if (_valor == Operacao.Acao.sel)
                {
                    using (var context = new ApplicationDBContext())
                    {
                        var idDonoFG = context.tblDono.First(a => a.Nome == nomeDono).IdDono;
                        var IdCaoFG = context.tblCao.First(a => a.IdCao == idDonoFG).IdCao;
                        Dono dono = context.tblDono.First(a => a.IdDono == idDonoFG);
                        Cao cao = context.tblCao.First(a => a.IdCao == IdCaoFG);
                        mdc.NomeDono = dono.Nome;
                        mdc.NomeCao = cao.Nome;
                        mdc.RacaCao = cao.Raca;
                        return mdc;
                    }
                }
                else if (_valor == Operacao.Acao.edit)
                {
                    using (var context = new ApplicationDBContext())
                    {
                        var dono = context.tblDono.First(a => a.Nome == nomeDono);
                        var iddono = dono.IdDono;
                        var cao = context.tblCao.First(a => a.IdCao == iddono);
                        dono.Nome = nomeDono;
                        cao.Nome = Nomecao;
                        cao.Raca = RacaCao;
                        context.Update(dono);
                        context.Update(cao);
                        context.SaveChanges();                        
                        return null;
                    }
                }
                else if (_valor == Operacao.Acao.del)
                {
                    using (var context = new ApplicationDBContext())
                    {
                        var dono = context.tblDono.First(a => a.Nome == nomeDono);
                        var iddono = dono.IdDono;
                        var cao = context.tblCao.First(a => a.IdCao == iddono);
                        var relacaoDono_Cao = context.tblDono_Cao.First(a => a.IdDono == iddono);
                        context.Remove(relacaoDono_Cao);
                        context.Remove(dono);
                        context.Remove(cao);
                        context.SaveChanges();                        
                        return null;
                    }
                }
                else if (_valor == Operacao.Acao.add)
                {
                    Dono d = new Dono();
                    Cao c = new Cao();
                    Relacao_Dono_Cao rdc = new Relacao_Dono_Cao();

                    using (var context = new ApplicationDBContext())
                    {
                        d.Nome = nomeDono;
                        c.Nome = Nomecao;
                        c.Raca = RacaCao;
                        context.Add(d);
                        context.Add(c);
                        context.SaveChanges();

                        var idDonoFG = context.tblDono.First(a => a.Nome == nomeDono).IdDono;
                        int idCaoFG = context.tblCao.First(a => a.Nome == nomeDono).IdCao;
                        rdc.IdDono = idDonoFG;
                        rdc.IdCao = idCaoFG;
                        context.Add(rdc);
                        context.SaveChanges();
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AcaoOperacao" + ex.Message); ;
                return null;
            }
        }
        public List<ModelDonoCao> Relatorio(string raca)
        {
            ModelDonoCao DonoECao = null;
            List<ModelDonoCao> relatorioDonoCao = null;
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    var caes = context.tblCao.Where(a => a.Raca == raca).ToList();
                    var donos = context.tblDono.ToList();
                    relatorioDonoCao = new List<ModelDonoCao>();
                    DonoECao = new ModelDonoCao();                    
                    foreach (var dono in donos)
                    {
                        foreach (var cao in caes)
                        {
                            if (cao.IdCao == dono.IdDono)
                            {
                                DonoECao.NomeDono = dono.Nome;
                                DonoECao.NomeCao = cao.Nome;
                                DonoECao.RacaCao = cao.Raca;
                                relatorioDonoCao.Add(DonoECao);
                            }
                        }
                    }
                    return relatorioDonoCao;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Relatorio: " + ex.Message);
                return null;
            }
        }
    }
}
