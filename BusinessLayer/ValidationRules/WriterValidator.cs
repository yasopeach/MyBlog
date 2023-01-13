using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez!");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez!");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola Boş Geçilemez!");
			RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Parola en az 8 karakterden oluşmalı.");
			RuleFor(x => x.WriterPassword).MaximumLength(16).WithMessage("Parola en fazla 8 karakterden oluşmalı.");
			RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harften ibaret olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifre en az bir kicik harfden ibaret olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifre en az bir rakamdan ibaret olmalıdır.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim en az iki karakterden oluşmalı.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim en fazla elli karakterden oluşmalı");
		}
	}
}
