CREATE TABLE alunos
(
  cod_alunos integer,
  nome_alun character varying(40),
  responsavel_nascimento varchar(50),
  nascimento varchar(50),
  cpf_aluno varchar(50),
  cpf_responsavel varchar(50),
  telefone varchar(50),
  endereco varchar(50),
  email varchar (50),
  codigopostal varchar (50),
  bairroesub varchar (50)
);

ALTER TABLE public.alunos
  OWNER TO umctvdbs;