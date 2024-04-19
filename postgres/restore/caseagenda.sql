--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

-- Started on 2024-04-19 05:28:53

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 216 (class 1259 OID 24751)
-- Name: userbase; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.userbase (
    id integer NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(255) NOT NULL,
    email character varying(255) NOT NULL,
    role character varying(50) NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.userbase OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 24750)
-- Name: userbase_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.userbase_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.userbase_id_seq OWNER TO postgres;

--
-- TOC entry 4846 (class 0 OID 0)
-- Dependencies: 215
-- Name: userbase_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.userbase_id_seq OWNED BY public.userbase.id;


--
-- TOC entry 4688 (class 2604 OID 24754)
-- Name: userbase id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.userbase ALTER COLUMN id SET DEFAULT nextval('public.userbase_id_seq'::regclass);


--
-- TOC entry 4840 (class 0 OID 24751)
-- Dependencies: 216
-- Data for Name: userbase; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.userbase (id, username, password, email, role, created_at) FROM stdin;
\.


--
-- TOC entry 4847 (class 0 OID 0)
-- Dependencies: 215
-- Name: userbase_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.userbase_id_seq', 17, true);


--
-- TOC entry 4691 (class 2606 OID 24763)
-- Name: userbase userbase_email_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.userbase
    ADD CONSTRAINT userbase_email_key UNIQUE (email);


--
-- TOC entry 4693 (class 2606 OID 24759)
-- Name: userbase userbase_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.userbase
    ADD CONSTRAINT userbase_pkey PRIMARY KEY (id);


--
-- TOC entry 4695 (class 2606 OID 24761)
-- Name: userbase userbase_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.userbase
    ADD CONSTRAINT userbase_username_key UNIQUE (username);


-- Completed on 2024-04-19 05:28:53

--
-- PostgreSQL database dump complete
--

