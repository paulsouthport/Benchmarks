using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
 [MemoryDiagnoser]
    public class CollectionBenchmarks
    {
        private List<Guid> _listGuids_10;
        private List<Guid> _listGuids_1_000;
        private List<Guid> _listGuids_100_000;
        private List<Guid> _listGuids_1_000_000;

        private HashSet<Guid> _hashSetGuids_10;
        private HashSet<Guid> _hashSetGuids_1_000;
        private HashSet<Guid> _hashSetGuids_100_000;
        private HashSet<Guid> _hashSetGuids_1_000_000;

        private Guid _searchValue;

        [GlobalSetup]

        public void Setup()
        {
            _listGuids_10 = new List<Guid>();
            for (int i = 0; i < 10; i++) _listGuids_10.Add(Guid.NewGuid());

            _listGuids_1_000 = new List<Guid>();
            for (int i = 0; i < 1000; i++) _listGuids_1_000.Add(Guid.NewGuid());

            _listGuids_100_000 = new List<Guid>();
            for (int i = 0; i < 100000; i++) _listGuids_100_000.Add(Guid.NewGuid());

            _listGuids_1_000_000 = new List<Guid>();
            for (int i = 0; i < 1000000; i++) _listGuids_1_000_000.Add(Guid.NewGuid());

            //***

            _hashSetGuids_10 = new HashSet<Guid>();
            for (int i = 0; i < 10; i++) _hashSetGuids_10.Add(Guid.NewGuid());

            _hashSetGuids_1_000 = new HashSet<Guid>();
            for (int i = 0; i < 1000; i++) _hashSetGuids_1_000.Add(Guid.NewGuid());

            _hashSetGuids_100_000 = new HashSet<Guid>();
            for (int i = 0; i < 100000; i++) _hashSetGuids_100_000.Add(Guid.NewGuid());

            _hashSetGuids_1_000_000 = new HashSet<Guid>();
            for (int i = 0; i < 1000000; i++) _hashSetGuids_1_000_000.Add(Guid.NewGuid());

            _searchValue = Guid.NewGuid();

        }

        [Benchmark]
        public bool FindGuid_10_UsingList()
        {
            return _listGuids_10.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_1_000_UsingList()
        {
            return _listGuids_1_000.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_100_000_UsingList()
        {
            return _listGuids_100_000.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_1_000_000_UsingList()
        {
            return _listGuids_1_000_000.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_10_UsingHashSet()
        {
            return _hashSetGuids_10.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_1_000_UsingHashSet()
        {
            return _hashSetGuids_1_000.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_100_000_UsingHashSet()
        {
            return _hashSetGuids_100_000.Contains(_searchValue);
        }

        [Benchmark]
        public bool FindGuid_1_000_000_UsingHashSet()
        {
            return _hashSetGuids_1_000_000.Contains(_searchValue);
        }
    }
}
